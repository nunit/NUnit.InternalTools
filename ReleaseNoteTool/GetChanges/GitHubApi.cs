using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Alteridem.GetChanges
{
    /// <summary>
    /// A simple class for communicating with GitHub
    /// </summary>
    internal class GitHubApi
    {
        private readonly GitHubClient _github;
        private readonly string _organization;
        private readonly string _repository;
        private readonly HttpClient httpClient;

        /// <summary>
        /// Constructs a class for talking to GitHub
        /// </summary>
        /// <param name="organization">The organization you are interested in</param>
        /// <param name="repository">The repository within an organization</param>
        public GitHubApi(string organization, string repository)
        {
            _organization = organization;
            _repository = repository;
            _github = new GitHubClient(new Octokit.ProductHeaderValue("Alteridem.GetChangeset"))
            {
                Credentials = new Credentials(Secrets.Token)
            };
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", Secrets.Token);
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Alteridem.GetChangeset");
        }

        public async Task<IReadOnlyList<Milestone>> GetOpenMilestones()
        {
            var request = new MilestoneRequest
            {
                State = ItemStateFilter.Open,
                SortProperty = MilestoneSort.DueDate,
                SortDirection = SortDirection.Descending
            };
            try
            {
                return await _github.Issue.Milestone.GetAllForRepository(_organization, _repository, request);
            }
            catch (Octokit.AuthorizationException ex)
            {
                Console.Error.WriteLine("Authorization failed. Please check your GitHub token or permissions.");
                Console.Error.WriteLine($"Details: {ex.Message}");
                // Depending on the application's requirements, you might want to re-throw,
                // return an empty list, or prompt the user for a new token.
                // For now, we'll just return an empty list.
                throw;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Failed to get milestones for repository, {0}", ex.Message);
                throw;
            }
        }

        public async Task<IReadOnlyList<Issue>> GetClosedIssuesForMilestone(Milestone milestone)
        {
            var request = new RepositoryIssueRequest
            {
                State = ItemStateFilter.Closed,
                SortProperty = IssueSort.Created,
                SortDirection = SortDirection.Descending,
                Milestone = milestone.Number.ToString()
            };
            try
            {
                return await _github.Issue.GetAllForRepository(_organization, _repository, request);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Failed to get issues for repository, {0}", ex.Message);
            }

            return new List<Issue>();
        }

        /// <summary>
        /// Actually gets either pull requests or issues by id
        /// </summary>
        public async Task<Issue> GetIssueOrPulLRequest(int id)
        {
            try
            {
                var pr = await _github.Issue.Get(_organization, _repository, id);
                return pr;

            }
            catch (ApiException e)
            {
                Console.Error.WriteLine($"Could not get Id={id}, exception: {e}");
                throw;
            }
        }

        public async Task<User> GetUser(string login)
        {
            try
            {
                var user = await _github.User.Get(login);
                return user;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"User {login} not found. {e}");
                return null;
            }
        }

        public async Task<HashSet<User>> GetCommentersAsync(int issueNumber)
        {
            var comments = await _github.Issue.Comment.GetAllForIssue(_organization, _repository, issueNumber);
            return comments
                .Select(comment => comment.User)
                .Where(user => !IsBot(user.Login))
                .ToHashSet(); // Unique list of commenters, excluding bots
        }

        /// <summary>
        /// Gets the [!IMPORTANT] note from an issue's body or comments
        /// </summary>
        public async Task<string> GetImportantNoteAsync(int issueNumber, string issueBody)
        {
            // First check the issue body
            var note = IssuePrItem.ExtractImportantNote(issueBody);
            if (!string.IsNullOrEmpty(note))
                return note;

            // Then check comments
            var comments = await _github.Issue.Comment.GetAllForIssue(_organization, _repository, issueNumber);
            foreach (var comment in comments)
            {
                note = IssuePrItem.ExtractImportantNote(comment.Body);
                if (!string.IsNullOrEmpty(note))
                    return note;
            }

            return null;
        }

        /// <summary>
        /// Checks if a user login belongs to a bot account
        /// </summary>
        private static bool IsBot(string login)
        {
            if (string.IsNullOrEmpty(login)) return false;
            return login.Contains("[bot]", StringComparison.OrdinalIgnoreCase) ||
                   login.StartsWith("app/", StringComparison.OrdinalIgnoreCase) ||
                   login.Equals("dependabot", StringComparison.OrdinalIgnoreCase) ||
                   login.Equals("copilot", StringComparison.OrdinalIgnoreCase) ||
                   login.Contains("copilot", StringComparison.OrdinalIgnoreCase) ||
                   login.EndsWith("-bot", StringComparison.OrdinalIgnoreCase);
        }


        /// <summary>
        /// Finds pull requests linked to an issue using GitHub's GraphQL API.
        /// This method queries timeline events to find PRs that either closed the issue
        /// or were cross-referenced (mentioned in commits, PR descriptions, etc.).
        /// </summary>
        /// <param name="issueNumber">The issue number to find linked PRs for</param>
        /// <returns>A list of PR numbers linked to this issue, ordered by relevance (closing PRs first)</returns>
        internal async Task<List<int>> FindLinkedPullRequests(int issueNumber)
        {
            var query = @"
                query($owner: String!, $repo: String!, $issueNumber: Int!) {
                    repository(owner: $owner, name: $repo) {
                        issue(number: $issueNumber) {
                            timelineItems(first: 100, itemTypes: [CLOSED_EVENT, CROSS_REFERENCED_EVENT, CONNECTED_EVENT]) {
                                nodes {
                                    __typename
                                    ... on ClosedEvent {
                                        closer {
                                            ... on PullRequest {
                                                number
                                                state
                                            }
                                        }
                                    }
                                    ... on CrossReferencedEvent {
                                        source {
                                            ... on PullRequest {
                                                number
                                                state
                                            }
                                        }
                                    }
                                    ... on ConnectedEvent {
                                        subject {
                                            ... on PullRequest {
                                                number
                                                state
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }";

            var requestBody = new
            {
                query,
                variables = new
                {
                    owner = _organization,
                    repo = _repository,
                    issueNumber
                }
            };

            var content = new StringContent(
                JsonSerializer.Serialize(requestBody),
                Encoding.UTF8,
                "application/json");

            var response = await httpClient.PostAsync("https://api.github.com/graphql", content);
            var responseBody = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                Console.Error.WriteLine($"GraphQL request failed for issue {issueNumber}: {response.StatusCode}");
                return [];
            }

            var closingPrs = new List<int>();
            var referencedPrs = new List<int>();

            using var doc = JsonDocument.Parse(responseBody);
            var root = doc.RootElement;

            if (root.TryGetProperty("errors", out var errors))
            {
                Console.Error.WriteLine($"GraphQL errors for issue {issueNumber}: {errors}");
                return [];
            }

            var issueElement = root
                .GetProperty("data")
                .GetProperty("repository")
                .GetProperty("issue");

            // Issue can be null if the number refers to a PR, not an issue
            if (issueElement.ValueKind == JsonValueKind.Null)
            {
                return [];
            }

            var nodes = issueElement
                .GetProperty("timelineItems")
                .GetProperty("nodes");

            foreach (var node in nodes.EnumerateArray())
            {
                var typeName = node.GetProperty("__typename").GetString();
                int? prNumber = null;
                string prState = null;

                switch (typeName)
                {
                    case "ClosedEvent":
                        if (node.TryGetProperty("closer", out var closer) &&
                            closer.ValueKind != JsonValueKind.Null &&
                            closer.TryGetProperty("number", out var closerNum))
                        {
                            prNumber = closerNum.GetInt32();
                            prState = closer.TryGetProperty("state", out var s) ? s.GetString() : null;
                            if (prNumber.HasValue && prState == "MERGED")
                            {
                                closingPrs.Add(prNumber.Value);
                            }
                        }
                        break;

                    case "CrossReferencedEvent":
                        if (node.TryGetProperty("source", out var source) &&
                            source.ValueKind != JsonValueKind.Null &&
                            source.TryGetProperty("number", out var sourceNum))
                        {
                            prNumber = sourceNum.GetInt32();
                            prState = source.TryGetProperty("state", out var s) ? s.GetString() : null;
                            if (prNumber.HasValue && prState == "MERGED" && !closingPrs.Contains(prNumber.Value))
                            {
                                referencedPrs.Add(prNumber.Value);
                            }
                        }
                        break;

                    case "ConnectedEvent":
                        if (node.TryGetProperty("subject", out var subject) &&
                            subject.ValueKind != JsonValueKind.Null &&
                            subject.TryGetProperty("number", out var subjectNum))
                        {
                            prNumber = subjectNum.GetInt32();
                            prState = subject.TryGetProperty("state", out var s) ? s.GetString() : null;
                            if (prNumber.HasValue && prState == "MERGED" &&
                                !closingPrs.Contains(prNumber.Value) && !referencedPrs.Contains(prNumber.Value))
                            {
                                referencedPrs.Add(prNumber.Value);
                            }
                        }
                        break;
                }
            }

            // Return closing PRs first (highest confidence), then referenced PRs
            var result = closingPrs.Distinct().Concat(referencedPrs.Distinct()).ToList();
            return result;
        }

        /// <summary>
        /// Finds the primary pull request linked to an issue.
        /// Prefers PRs that closed the issue over those that just referenced it.
        /// </summary>
        internal async Task<int> FindPullRequestNumber(int issueNumber)
        {
            var linkedPrs = await FindLinkedPullRequests(issueNumber);

            if (linkedPrs.Count > 0)
            {
                return linkedPrs[0];
            }

            Console.Error.WriteLine($"{issueNumber}, No pull request found");
            return -1;
        }

        /// <summary>
        /// Gets the effective author of a PR. If the PR was authored by a bot (e.g., Copilot),
        /// this returns the human who triggered the bot or merged the PR.
        /// </summary>
        /// <param name="prNumber">The PR number</param>
        /// <returns>A tuple of (login, name, htmlUrl) for the effective author</returns>
        internal async Task<(string Login, string Name, string HtmlUrl, bool IsBot)> GetEffectivePrAuthor(int prNumber)
        {
            var query = @"
                query($owner: String!, $repo: String!, $prNumber: Int!) {
                    repository(owner: $owner, name: $repo) {
                        pullRequest(number: $prNumber) {
                            author {
                                login
                                ... on User {
                                    name
                                    url
                                }
                                ... on Bot {
                                    url
                                }
                            }
                            mergedBy {
                                login
                                ... on User {
                                    name
                                    url
                                }
                            }
                            comments(first: 20) {
                                nodes {
                                    author {
                                        login
                                        ... on User {
                                            name
                                            url
                                        }
                                    }
                                    body
                                }
                            }
                        }
                    }
                }";

            var requestBody = new
            {
                query,
                variables = new
                {
                    owner = _organization,
                    repo = _repository,
                    prNumber
                }
            };

            var content = new StringContent(
                JsonSerializer.Serialize(requestBody),
                Encoding.UTF8,
                "application/json");

            var response = await httpClient.PostAsync("https://api.github.com/graphql", content);
            var responseBody = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                Console.Error.WriteLine($"GraphQL request failed for PR {prNumber}: {response.StatusCode}");
                return (null, null, null, false);
            }

            using var doc = JsonDocument.Parse(responseBody);
            var root = doc.RootElement;

            if (root.TryGetProperty("errors", out var errors))
            {
                Console.Error.WriteLine($"GraphQL errors for PR {prNumber}: {errors}");
                return (null, null, null, false);
            }

            var pr = root
                .GetProperty("data")
                .GetProperty("repository")
                .GetProperty("pullRequest");

            // Get author info
            var author = pr.GetProperty("author");
            var authorLogin = author.TryGetProperty("login", out var loginProp) ? loginProp.GetString() : null;
            var authorName = author.TryGetProperty("name", out var nameProp) ? nameProp.GetString() : null;
            var authorUrl = author.TryGetProperty("url", out var urlProp) ? urlProp.GetString() : null;

            // Check if author is a bot
            bool isBot = IsBot(authorLogin);

            if (!isBot)
            {
                return (authorLogin, authorName, authorUrl, false);
            }

            // It's a bot - try to find who triggered it from comments
            if (pr.TryGetProperty("comments", out var comments) &&
                comments.TryGetProperty("nodes", out var commentNodes))
            {
                foreach (var comment in commentNodes.EnumerateArray())
                {
                    if (comment.TryGetProperty("body", out var bodyProp))
                    {
                        var body = bodyProp.GetString() ?? "";
                        // Look for @copilot mentions which indicate who triggered the bot
                        if (body.Contains("@copilot", StringComparison.OrdinalIgnoreCase))
                        {
                            if (comment.TryGetProperty("author", out var commentAuthor))
                            {
                                var triggerLogin = commentAuthor.TryGetProperty("login", out var tl) ? tl.GetString() : null;
                                var triggerName = commentAuthor.TryGetProperty("name", out var tn) ? tn.GetString() : null;
                                var triggerUrl = commentAuthor.TryGetProperty("url", out var tu) ? tu.GetString() : null;

                                if (!string.IsNullOrEmpty(triggerLogin))
                                {
                                    return (triggerLogin, triggerName, triggerUrl, true);
                                }
                            }
                        }
                    }
                }
            }

            // Fall back to mergedBy
            if (pr.TryGetProperty("mergedBy", out var mergedBy) && mergedBy.ValueKind != JsonValueKind.Null)
            {
                var mergerLogin = mergedBy.TryGetProperty("login", out var ml) ? ml.GetString() : null;
                var mergerName = mergedBy.TryGetProperty("name", out var mn) ? mn.GetString() : null;
                var mergerUrl = mergedBy.TryGetProperty("url", out var mu) ? mu.GetString() : null;

                if (!string.IsNullOrEmpty(mergerLogin))
                {
                    return (mergerLogin, mergerName, mergerUrl, true);
                }
            }

            // Last resort - return the bot info
            return (authorLogin, authorName, authorUrl, true);
        }
    }
}

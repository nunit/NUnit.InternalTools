using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

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
            catch (Exception ex)
            {
                Console.WriteLine("Failed to get milestones for repository, {0}", ex.Message);
            }

            return new List<Milestone>();
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
                Console.WriteLine("Failed to get issues for repository, {0}", ex.Message);
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
                Console.WriteLine($"Could not get Id={id}, exception: {e}");
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
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<HashSet<User>> GetCommentersAsync(int issueNumber)
        {
            var comments = await _github.Issue.Comment.GetAllForIssue(_organization, _repository, issueNumber);
            return comments.Select(comment => comment.User).ToHashSet(); // Unique list of commenters
        }


        internal async Task<int> FindPullRequestNumber(int issueNumber)
        {
            var issueUrl = $"https://github.com/{_organization}/{_repository}/issues/{issueNumber}";

            // Step 1: Retrieve the issue's HTML content
            var htmlResponse = await httpClient.GetStringAsync(issueUrl);

            // Step 2: Parse the HTML to find the pull request link
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(htmlResponse);

            var link = htmlDoc.DocumentNode
                .SelectSingleNode("//a[contains(@href,'/pull/')]");

            if (link != null &&
                Regex.Match(link.GetAttributeValue("href", ""), @"/pull/(\d+)")
                    .Groups[1].Success)
            {
                // Extract the pull request number from the link
                var prNumber = Regex.Match(link.GetAttributeValue("href", ""), @"/pull/(\d+)")
                    .Groups[1].Value;
                return Convert.ToInt32(prNumber);
            }

            Console.WriteLine($"{issueNumber}, No pull request found");
            return -1;
        }
       
    }
}

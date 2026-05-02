using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Octokit;

namespace Alteridem.GetChanges;

internal class Loader(Options options)
{
    public GitHubApi Github { get; } = new(options.Organization, options.Repository);
    public Milestone Milestone { get; private set; }

    public IssuesPrList IssuePrItemList { get; set; } = new();

    internal async Task LoadMilestone()
    {
        Console.Out.WriteLine($"Loading milestone '{options.Milestone}'...");
        var milestones = await Github.GetOpenMilestones();
        Milestone = milestones.FirstOrDefault(m => m.Title == options.Milestone);
        if (Milestone != null)
            Console.Out.WriteLine($"Found milestone: {Milestone.Title} (#{Milestone.Number})");
    }

    /// <summary>
    /// Require LoadMilestone to be called first
    /// </summary>
    /// <returns></returns>
    internal async Task LoadIssues()
    {
        if (Milestone == null)
        {
            Console.Error.WriteLine("Error: Milestone not found");
            return;
        }
        Console.Out.WriteLine("Loading issues from GitHub...");
        var issues = await Github.GetClosedIssuesForMilestone(Milestone);
        Console.Out.WriteLine($"Found {issues.Count} closed issues in milestone");

        int processed = 0;
        foreach (var issue in issues)
        {
            try
            {
                var issuePr = await LoadIssueWithPr(issue);
                IssuePrItemList.Add(issuePr);
                processed++;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error processing issue #{issue.Number}: {ex.Message}");
            }
        }
        Console.Out.WriteLine($"Successfully loaded {IssuePrItemList.Items.Count} of {issues.Count} issues");
    }
    internal async Task<IssuePrItem> LoadIssueWithPr(Issue issue)
    {
        var commenters = await Github.GetCommentersAsync(issue.Number);
        var prNumber = await Github.FindPullRequestNumber(issue.Number);
        var issuePr = new IssuePrItem(issue)
        {
            Commenters = commenters,
            PrNumber = prNumber,
            IssueId = issue.Number
        };
        if (prNumber > 0)
        {
            var pr = await Github.GetIssueOrPulLRequest(prNumber);
            issuePr.PullRequest = pr;
            issuePr.PullRequestCommenters = await Github.GetCommentersAsync(prNumber);

            // Get effective author (resolves bot authors to the human who triggered/merged)
            var (login, name, url, isBot) = await Github.GetEffectivePrAuthor(prNumber);
            issuePr.PrAuthorNick = login ?? pr.User.Login;
            issuePr.PrAuthor = name ?? login ?? pr.User.Login;
            issuePr.PrAuthorUrl = url ?? pr.User.HtmlUrl;
        }

        // For breaking changes, fetch the [!IMPORTANT] note from body or comments
        Console.Out.WriteLine($"  Issue #{issue.Number} labels: [{string.Join(", ", issuePr.Labels)}]");
        if (issuePr.LabelStartsWith("Breaking"))
        {
            Console.Out.WriteLine($"  Issue #{issue.Number} IS a breaking change, fetching IMPORTANT note...");
            issuePr.ImportantNote = await Github.GetImportantNoteAsync(issue.Number, issue.Body);
            Console.Out.WriteLine($"  Issue #{issue.Number} ImportantNote: {(string.IsNullOrEmpty(issuePr.ImportantNote) ? "(empty)" : issuePr.ImportantNote)}");
        }

        return issuePr;
    }

    /// <summary>
    /// Require LoadIssues to be called first
    /// </summary>
    /// <returns></returns>
    //public async Task LoadUserNames()
    //{
    //    MoveUsers();
    //    foreach (var user in IssuePrItemList.Users)
    //    {
    //        var userDetail = await Github.GetUser(user.Login);
    //        IssuePrItemList.UserNames.Add(new UserName {Login=user.Login,Name=userDetail.Name, HtmlUrl = userDetail.HtmlUrl});
    //    }
    //}

    /// <summary>
    /// Picks up all users from the issues and moves them to the user list
    /// The issue reporter, the PR author, and all commenters
    /// </summary>
    private void MoveUsers()
    {
        foreach (var issue in IssuePrItemList.Items)
        {
            // Add reporter
            var user = IssuePrItemList.Users.FirstOrDefault(u => u.Login == issue.Issue.User.Login);
            if (user == null)
            {
                IssuePrItemList.Users.Add(issue.Issue.User);
            }
            // Add effective PR author (already resolved from bot to human if applicable)
            if (!string.IsNullOrEmpty(issue.PrAuthorNick))
            {
                // Add to UserNames directly since we already have the info from GraphQL
                var existingUser = IssuePrItemList.UserNames.FirstOrDefault(u => u.Login == issue.PrAuthorNick);
                if (existingUser == null)
                {
                    IssuePrItemList.UserNames.Add(new UserName
                    {
                        Login = issue.PrAuthorNick,
                        Name = issue.PrAuthor,
                        HtmlUrl = issue.PrAuthorUrl
                    });
                }
            }
            // Add commenters
            foreach (var commenter in issue.Commenters)
            {
                user = IssuePrItemList.Users.FirstOrDefault(u => u.Login == commenter.Login);
                if (user == null)
                {
                    IssuePrItemList.Users.Add(commenter);
                }
            }
            // Add PR commenters
            if (issue.PullRequestCommenters != null)
            {
                foreach (var commenter in issue.PullRequestCommenters)
                {
                    user = IssuePrItemList.Users.FirstOrDefault(u => u.Login == commenter.Login);
                    if (user == null)
                    {
                        IssuePrItemList.Users.Add(commenter);
                    }
                }
            }
        }
    }

    private const string CacheFilePath = "UserNameCache.json";

    /// <summary>
    /// Require LoadIssues to be called first
    /// </summary>
    /// <returns></returns>
    public async Task LoadUserNames()
    {
        Console.Out.WriteLine("Loading user information...");

        // Load cached usernames from file
        await LoadCacheAsync();
        Console.Out.WriteLine($"  Loaded {IssuePrItemList.UserNames.Count} users from cache");

        // Ensure users are moved
        MoveUsers();

        // Find users not in cache
        var usersToFetch = IssuePrItemList.Users
            .Where(user => IssuePrItemList.UserNames.All(cached => cached.Login != user.Login))
            .ToList();

        if (usersToFetch.Count > 0)
        {
            Console.Out.WriteLine($"  Fetching {usersToFetch.Count} users from GitHub...");
            int fetched = 0;
            // Fetch missing users from GitHub
            foreach (var user in usersToFetch)
            {
                var userDetail = await Github.GetUser(user.Login);
                IssuePrItemList.UserNames.Add(new UserName
                {
                    Login = user.Login,
                    Name = userDetail?.Name??user.Login,
                    HtmlUrl = userDetail?.HtmlUrl??""
                });
                fetched++;
                Console.Out.Write($"\r  Fetching users: {fetched}/{usersToFetch.Count}");
            }
            Console.Out.WriteLine();
        }

        // Save updated cache to file
        await SaveCacheAsync();
        Console.Out.WriteLine($"  Total users: {IssuePrItemList.UserNames.Count}");
    }

    private async Task LoadCacheAsync()
    {
        if (File.Exists(CacheFilePath))
        {
            var json = await File.ReadAllTextAsync(CacheFilePath);
            var cachedUsers = JsonSerializer.Deserialize<HashSet<UserName>>(json);

            if (cachedUsers != null)
            {
                foreach (var user in cachedUsers)
                {
                    IssuePrItemList.UserNames.Add(user);
                }
            }
        }
    }

    private async Task SaveCacheAsync()
    {
        var json = JsonSerializer.Serialize(IssuePrItemList.UserNames);
        await File.WriteAllTextAsync(CacheFilePath, json);
    }

    public void UpdatePrAuthors()
    {
        // PR authors are now set in LoadIssueWithPr using GetEffectivePrAuthor
        // This method only fills in missing author info for edge cases
        foreach (var item in IssuePrItemList.Items)
        {
            if (item.PullRequest != null && string.IsNullOrEmpty(item.PrAuthor))
            {
                var user = IssuePrItemList.UserNames.FirstOrDefault(u => u.Login == item.PrAuthorNick);
                if (user != null)
                {
                    item.PrAuthor = !string.IsNullOrEmpty(user.Name) ? user.Name : user.Login;
                }
            }
        }
    }
}
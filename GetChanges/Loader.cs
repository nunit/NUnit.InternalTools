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
        var milestones = await Github.GetOpenMilestones();
        Milestone = milestones.FirstOrDefault(m => m.Title == options.Milestone);
    }

    /// <summary>
    /// Require LoadMilestone to be called first
    /// </summary>
    /// <returns></returns>
    internal async Task LoadIssues()
    {
        if (Milestone == null)
        {
            Console.WriteLine("Milestone not found");
            return;
        }
        var issues = await Github.GetClosedIssuesForMilestone(Milestone);
        foreach (var issue in issues)
        {
            var issuePr = await LoadIssueWithPr(issue);
            IssuePrItemList.Add(issuePr);
        }
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
            // Add PR author
            if (issue.PullRequest != null)
            {
                user = IssuePrItemList.Users.FirstOrDefault(u => u.Login == issue.PullRequest.User.Login);
                if (user == null)
                {
                    IssuePrItemList.Users.Add(issue.PullRequest.User);
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
        // Load cached usernames from file
        await LoadCacheAsync();

        // Ensure users are moved
        MoveUsers();

        // Find users not in cache
        var usersToFetch = IssuePrItemList.Users
            .Where(user => IssuePrItemList.UserNames.All(cached => cached.Login != user.Login))
            .ToList();

        // Fetch missing users from GitHub
        foreach (var user in usersToFetch)
        {
            var userDetail = await Github.GetUser(user.Login);
            IssuePrItemList.UserNames.Add(new UserName
            {
                Login = user.Login,
                Name = userDetail.Name,
                HtmlUrl = userDetail.HtmlUrl
            });
        }

        // Save updated cache to file
        await SaveCacheAsync();
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
        foreach (var item in IssuePrItemList.Items)
        {
            if (item.PullRequest != null)
            {
                var user = IssuePrItemList.UserNames.FirstOrDefault(u => u.Login == item.PullRequest.User.Login);
                if (user != null)
                {
                    item.PrAuthor = !string.IsNullOrEmpty(user.Name) ? user.Name : user.Login;
                }
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Octokit;

namespace Alteridem.GetChanges;

public class IssuePrItem(Issue issue)
{
    public int IssueId { get; set; }
    public int PrNumber { get; set; }

    public Issue PullRequest { get; set; }
    
    public string Title => Issue.Title.EndsWith(".") ? Issue.Title : Issue.Title+".";
    public List<string> Labels => Issue.Labels.Select(l => l.Name).ToList();

    public string PrAuthorNick => PullRequest?.User.Login ?? "";

    public string PrAuthor { get; set; } = "";

    public string ReporterNick => Issue.User.Login;

    public HashSet<User> Commenters { get; set; } = [];
    public Issue Issue { get; set; } = issue;
    public HashSet<User> PullRequestCommenters { get; set; }
}

public class UserName
{
    /// <summary>
    /// Aka Nickname
    /// </summary>
    public string Login { get; set; }
    public string Name { get; set; }
    public string HtmlUrl { get; set; }
}


public class IssuesPrList 
{
    public HashSet<User> Users { get; set; } = [];
    public HashSet<UserName> UserNames { get; set; } = [];
    public List<IssuePrItem> Items { get; set; } = [];

    public void Add(IssuePrItem item)
    {
        Items.Add(item);
        Users.UnionWith(item.Commenters);
    }
}

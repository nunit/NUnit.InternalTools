using CommandLine;
using Octokit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Alteridem.GetChanges;

class Program
{
    static async Task Main(string[] args)
    {
        await Parser.Default
            .ParseArguments<Options>(args)
            .WithParsedAsync(MainAsync);
    }

    static async Task MainAsync(Options options)
    {
        if (!Secrets.Configured || options.Configure)
        {
            Secrets.Configure();
            return;
        }

        var github = new GitHubApi(options.Organization, options.Repository);
        var milestones = await github.GetOpenMilestones();
        if (options.Milestone.Length == 0) // No specific milestone, so let us run through the most current open milestones
        {
            foreach (var milestone in milestones.Where(m =>
                         m.DueOn != null && m.DueOn.Value.Subtract(DateTimeOffset.Now).TotalDays < 30))
            {
                await LoadIssuePr(github, milestone.Title.Trim());
                await LoadAndDisplayIssues(milestone);
            }
        }
        else // We have a specific milestone, hopefully
        {
            var milestone = milestones.FirstOrDefault(m => m.Title == options.Milestone);
            if (milestone != null)
            {
                await LoadIssuePr(github, milestone.Title.Trim());
                await LoadAndDisplayIssues(milestone);
            }
            else
            {
                Console.WriteLine("Milestone {0} not found", options.Milestone);
            }
        }

        async Task LoadAndDisplayIssues(Milestone milestone)
        {
            var milestoneIssues = await github.GetClosedIssuesForMilestone(milestone);
            DisplayIssuesForMilestone(options, milestone.Title, milestoneIssues);
        }
    }
    private static readonly Dictionary<int,IssuePrItem> IssuesPrs = new();
    private static async Task LoadIssuePr(GitHubApi gitHubApi, string milestone)
    {
        var lines = await File.ReadAllLinesAsync($"issuespr.{milestone}.txt");
        var userDict = new Dictionary<string, Octokit.User>();
        foreach (var line in lines)
        {
            var parts = line.Split(',');
            if (parts.Length >= 2)
            {
                var issue = int.Parse(parts[0]);
                var pr = int.Parse(parts[1]);
                var prItem = new IssuePrItem { Issue = issue, Pr = pr, Team = (parts.Length >= 3 && parts[2].Trim().Length > 0) };
                if (parts.Length >= 4)
                    prItem.Comment = parts[3];
                var pullrequest = await gitHubApi.GetIssueOrPulLRequest(pr);
                prItem.AuthorNick = pullrequest.User.Login;
                if (!userDict.TryGetValue(pullrequest.User.Login,out var user))
                {
                    user = await gitHubApi.GetUser(pullrequest.User.Login);
                    userDict.Add(pullrequest.User.Login, user);
                }
                prItem.Author = user.Name;
                if (IssuesPrs.ContainsKey(prItem.Issue))
                    Console.WriteLine($"Duplicate issue {prItem.Issue} in table");
                else
                    IssuesPrs.Add(prItem.Issue,prItem);
            }
        }
    }


    static void DisplayIssuesForMilestone(Options options, string milestone, IEnumerable<Issue> issues)
    {
        Console.WriteLine("## {0}", milestone);
        Console.WriteLine();
        var closedDoneIssues = issues.Where(o => o.ClosedDone() && o.PullRequest == null)
            .OrderByDescending(o => o.Number)
            .ToList();
        Console.WriteLine($"There are {closedDoneIssues.Count} issues fixed in this release.");
        Console.WriteLine();
        var processedIssues = new List<Issue>();
        DisplaySection(options, processedIssues, closedDoneIssues, "### Enhancements", new List<string>() { "is:enhancement","is:idea","is:feature"});
        // DisplaySection(options, processedIssues, closedDoneIssues, "### New features","is:feature");
        DisplaySection(options, processedIssues, closedDoneIssues, "### Bug fixes", new List<string>() { "is:bug"});
        DisplaySection(options, processedIssues, closedDoneIssues, "### Refactorings",new List<string>() {  "is:refactor"});
        DisplaySection(options, processedIssues, closedDoneIssues, "### Internal fixes", new List<string>() { "is:internal","is:build" });
        DisplaySection(options, processedIssues, closedDoneIssues, "### Deprecated features", new List<string>() { "is:deprecation" });
        // Write of the rest
        var rest = closedDoneIssues.Except(processedIssues).OrderByDescending(o => o.Number).ToList();
        if (rest.Any())
        {
            Console.WriteLine("### Others");
            Console.WriteLine();
            DisplayIssuesWithLabel(rest, "", options);
            Console.WriteLine();
        }
        DisplaySection(options, processedIssues, closedDoneIssues, "### The following issues are marked as breaking changes", new List<string>() { "Breaking"});
    }

    private static void DisplaySection(Options options, List<Issue> processedIssues, IEnumerable<Issue> closedDoneIssues, string header, IEnumerable<string> searchTerms)
    {
        Console.WriteLine(header);
        Console.WriteLine();
        int count=0;
        foreach (var searchTerm in searchTerms)
        {
            var issues = DisplayIssuesWithLabel(closedDoneIssues, searchTerm, options).ToList();
            processedIssues.AddRange(issues);
            count += issues.Count;
        }
        if (count==0)
            Console.WriteLine("None");
        Console.WriteLine();
    }

    static IEnumerable<Issue> DisplayIssuesWithLabel(IEnumerable<Issue> issues, string label, Options options)
    {
        var url = $"https://github.com/{options.Organization}/{options.Repository}";
        var list = issues.Where(o => o.LabelStartsWith(label)).ToList();
        foreach (var issue in list)
        {
            bool found = IssuesPrs.TryGetValue(issue.Number,out var prItem);
            string prText = "";
            if (found)
            {
                prText = prItem.Team ? $"Fixed by team [PR {prItem.Pr}]({url}/pull/{prItem.Pr})" : $"Thanks to [{prItem.Author}](https://github.com/{prItem.AuthorNick}) for [PR {prItem.Pr}]({url}/pull/{prItem.Pr})";
                prText = prText.Replace("<", "&lt;" ).Replace(">", "&gt;");
            }
            string comment = "";
            if (found && prItem.Comment.Length > 0)
                comment = $" ({prItem.Comment})";
            string title = issue.Title.Replace("<", "&lt;").Replace(">", "&gt;");
            Console.WriteLine(options.LinkIssues
                ? $"* [{issue.Number:####}]({url}/issues/{issue.Number}) {title}. {prText}{comment}"
                : $"* {issue.Number:####} {issue.Title}");
        }
        return list;
    }

}

public static class Extensions
{
    public static bool LabelExist(this Issue issue, string labelName)
    {
        return issue.Labels.FirstOrDefault(l => l.Name == labelName) != null;
    }

    public static bool LabelStartsWith(this Issue issue, string labelName)
    {
        return issue.Labels.FirstOrDefault(l => l.Name.StartsWith(labelName)) != null;
    }

    /// <summary>
    /// Issue is either not labeled with closed: or is labeled with closed:done
    /// </summary>
    public static bool ClosedDone(this Issue issue)
    {
        var label = issue.Labels.FirstOrDefault(l => l.Name.StartsWith("closed:"));
        return label == null || label.Name.EndsWith("done");
    }
}

public class IssuePrItem
{
    public int Issue { get; set; }
    public int Pr { get; set; }
    public bool Team { get; set; }

    public string Comment { get; set; } = "";

    public string Author { get; set; }

    public string AuthorNick { get; set; }
}

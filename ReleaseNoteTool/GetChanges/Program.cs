using CommandLine;
using Octokit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

        var loader = new Loader(options);
        await loader.LoadMilestone();
        await loader.LoadIssues();
        await loader.LoadUserNames();
        loader.UpdatePrAuthors();

        // Display the changes

        await DisplayIssuesForMilestone(options, loader.Milestone.Title, loader.IssuePrItemList);

    }

    static async Task DisplayIssuesForMilestone(Options options, string milestone, IssuesPrList issues)
    {
        Console.WriteLine("## {0}", milestone);
        Console.WriteLine();
        var closedDoneIssues = issues.Items
            .OrderByDescending(o => o.IssueId)
            .ToList();
        Console.WriteLine($"There are {closedDoneIssues.Count} issues fixed in this release.");
        Console.WriteLine();
        var processedIssues = new List<IssuePrItem>();
        DisplaySection(options, processedIssues, closedDoneIssues, "### Enhancements", new List<string> { "is:enhancement", "is:idea", "is:feature" });
        // DisplaySection(options, processedIssues, closedDoneIssues, "### New features","is:feature");
        DisplaySection(options, processedIssues, closedDoneIssues, "### Bug fixes", new List<string> { "is:bug" });
        DisplaySection(options, processedIssues, closedDoneIssues, "### Refactorings", new List<string> { "is:refactor" });
        DisplaySection(options, processedIssues, closedDoneIssues, "### Internal fixes", new List<string> { "is:internal", "is:build" });
        DisplaySection(options, processedIssues, closedDoneIssues, "### Deprecated features", new List<string> { "is:deprecation" });
        // Write of the rest
        var rest = closedDoneIssues.Except(processedIssues).OrderByDescending(o => o.IssueId).ToList();
        if (rest.Any())
        {
            Console.WriteLine("### Others");
            Console.WriteLine();
            DisplayIssuesWithLabel(rest, "", options);
            Console.WriteLine();
        }
        DisplaySection(options, processedIssues, closedDoneIssues, "### The following issues are marked as breaking changes", new List<string> { "Breaking" });
        Console.WriteLine();
        Console.WriteLine("### Acknowledgements");
        Console.WriteLine();
        Console.WriteLine("We want to express our heartfelt gratitude to everyone who has contributed to this release\nby reporting bugs, suggesting enhancements, and providing valuable feedback.\nYour efforts help make NUnit better for the entire community.");
        Console.WriteLine();
        Console.WriteLine("A special thank you to the following reporters for identifying issues:");
        Console.WriteLine();
        await DisplayReporters(issues);
        Console.WriteLine();
        Console.WriteLine("and to the commenters who engaged in discussions and offered further insights:");
        Console.WriteLine();
        await DisplayCommenters(issues);


    }

    private static async Task DisplayReporters(IssuesPrList issues)
    {
        List<UserName> reporterList = [];
        foreach (var issue in issues.Items)
        {
            var user = issues.UserNames.FirstOrDefault(o => o.Login == issue.ReporterNick);
            if (!reporterList.Contains(user))
                reporterList.Add(user);
        }

        var listOfReporters = GenerateReporterTable(reporterList);
        Console.WriteLine(listOfReporters);
    }

    public static string GenerateReporterTable(List<UserName> reporters)
    {
        if (reporters == null || reporters.Count == 0)
            return string.Empty;

        var sb = new StringBuilder();
        sb.AppendLine("<table>");

        var sortedReporters = reporters.OrderBy(r => r.Name ?? r.Login).ToList();

        int counter = 0;
        foreach (var reporter in sortedReporters)
        {
            if (counter % 4 == 0) sb.AppendLine("<tr>"); // Start a new row for every 4 items

            sb.AppendLine($"<td><a href=\"{reporter.HtmlUrl}\">{reporter.Name ?? reporter.Login}</a></td>");

            counter++;

            if (counter % 4 == 0 || counter == sortedReporters.Count) sb.AppendLine("</tr>"); // Close the row
        }
        sb.AppendLine("</table>");
        return sb.ToString();
    }

    private static async Task DisplayCommenters(IssuesPrList issues)
    {
        List<UserName> commenterList = [];
        foreach (var issue in issues.Items)
        {
            foreach (var commenter in issue.Commenters)
            {
                var user = issues.UserNames.FirstOrDefault(o => o.Login == commenter.Login);
                if (!commenterList.Contains(user))
                    commenterList.Add(user);
            }

            if (issue.PullRequestCommenters != null)
            {
                foreach (var commenter in issue.PullRequestCommenters)
                {
                    var user = issues.UserNames.FirstOrDefault(o => o.Login == commenter.Login);
                    if (!commenterList.Contains(user))
                        commenterList.Add(user);
                }
            }
        }

        var listOfCommenters = GenerateReporterTable(commenterList);
        Console.WriteLine(listOfCommenters);

    }



    private static void DisplaySection(Options options, List<IssuePrItem> processedIssues, List<IssuePrItem> closedDoneIssues, string header, IEnumerable<string> searchTerms)
    {
        Console.WriteLine(header);
        Console.WriteLine();
        int count = 0;
        foreach (var searchTerm in searchTerms)
        {
            var issues = DisplayIssuesWithLabel(closedDoneIssues, searchTerm, options).ToList();
            processedIssues.AddRange(issues);
            count += issues.Count;
        }
        Console.WriteLine(count == 0 ? "None" : "");

    }

    static IEnumerable<IssuePrItem> DisplayIssuesWithLabel(List<IssuePrItem> issues, string label, Options options)
    {
        var url = $"https://github.com/{options.Organization}/{options.Repository}";
        var list = issues.Where(o => o.LabelStartsWith(label)).ToList();
        foreach (var issue in list)
        {
            string prText = "";
            bool found = issue.PrNumber > 0;
            if (found)
            {
                prText = PullRequestMentions(issue, url);
                prText = prText.Replace("<", "&lt;").Replace(">", "&gt;");
            }
            string title = issue.Title.Replace("<", "&lt;").Replace(">", "&gt;");
            Console.WriteLine(options.LinkIssues
                ? $"* [{issue.IssueId:####}]({url}/issues/{issue.IssueId}) {title} {prText}"
                : $"* {issue.IssueId:####} {issue.Title}");
        }
        return list;
    }

    static string PullRequestMentions(IssuePrItem prItem, string url)
    {
        string[] teammembers = ["manfred-brands", "OsirisTerje", "stevenaw"];
        return teammembers.Contains(prItem.PrAuthorNick)
            ? $"Thanks to NUnit Team member [{prItem.PrAuthor}](https://github.com/{prItem.PrAuthorNick}) for [PR {prItem.PrNumber}]({url}/pull/{prItem.PrNumber})"
            : $"Thanks to [{prItem.PrAuthor}](https://github.com/{prItem.PrAuthorNick}) for [PR {prItem.PrNumber}]({url}/pull/{prItem.PrNumber})";
    }

}
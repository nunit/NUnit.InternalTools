using CommandLine;
using Octokit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alteridem.GetChanges;

class Program
{
    private static TextWriter Output = Console.Out;

    /// <summary>
    /// Gets the full output path by combining the DataDirectory setting with the filename.
    /// If the file path is already absolute, returns it as-is.
    /// </summary>
    private static string GetOutputPath(string fileName)
    {
        // If it's already an absolute path, use it directly
        if (Path.IsPathRooted(fileName))
        {
            Console.Out.WriteLine($"  Using absolute path: {fileName}");
            return fileName;
        }

        // Get the data directory from config, relative to the executable location
        var dataDir = ConfigurationManager.AppSettings["DataDirectory"];
        Console.Out.WriteLine($"  DataDirectory from config: {dataDir ?? "(not set)"}");

        if (string.IsNullOrEmpty(dataDir))
        {
            Console.Out.WriteLine($"  No DataDirectory configured, using current directory");
            return fileName;
        }

        // Resolve relative to the executable's directory
        var exeDir = AppContext.BaseDirectory;
        Console.Out.WriteLine($"  Executable directory: {exeDir}");

        var fullDataDir = Path.GetFullPath(Path.Combine(exeDir, dataDir));
        Console.Out.WriteLine($"  Resolved data directory: {fullDataDir}");

        // Ensure the directory exists
        if (!Directory.Exists(fullDataDir))
        {
            Console.Out.WriteLine($"  Creating directory: {fullDataDir}");
            Directory.CreateDirectory(fullDataDir);
        }

        return Path.Combine(fullDataDir, fileName);
    }

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

        // Set up output destination
        StreamWriter fileWriter = null;
        if (!string.IsNullOrEmpty(options.OutputFile))
        {
            var outputPath = GetOutputPath(options.OutputFile);
            fileWriter = new StreamWriter(outputPath, false, Encoding.UTF8);
            Output = fileWriter;
            Console.Out.WriteLine($"Writing release notes to: {outputPath}");
        }

        try
        {
            var loader = new Loader(options);
            await loader.LoadMilestone();
            await loader.LoadIssues();
            await loader.LoadUserNames();
            loader.UpdatePrAuthors();

            // Display the changes
            Console.Out.WriteLine("Generating release notes...");
            await DisplayIssuesForMilestone(options, loader.Milestone.Title, loader.IssuePrItemList);
        }
        finally
        {
            if (fileWriter != null)
            {
                await fileWriter.FlushAsync();
                fileWriter.Close();
                Console.Out.WriteLine("Done.");
            }
        }
    }

    static async Task DisplayIssuesForMilestone(Options options, string milestone, IssuesPrList issues)
    {
        Output.WriteLine("## {0}", milestone);
        Output.WriteLine();
        var closedDoneIssues = issues.Items
            .OrderByDescending(o => o.IssueId)
            .ToList();
        Output.WriteLine($"There are {closedDoneIssues.Count} issues fixed in this release.");
        Output.WriteLine();
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
            Output.WriteLine("### Others");
            Output.WriteLine();
            DisplayIssueList(rest, options);
            Output.WriteLine();
        }
        DisplayBreakingChanges(options, closedDoneIssues);
        Output.WriteLine();
        Output.WriteLine("### Acknowledgements");
        Output.WriteLine();
        Output.WriteLine("We want to express our heartfelt gratitude to everyone who has contributed to this release\nby reporting bugs, suggesting enhancements, and providing valuable feedback.\nYour efforts help make NUnit better for the entire community.");
        Output.WriteLine();
        Output.WriteLine("A special thank you to the following reporters for identifying issues:");
        Output.WriteLine();
        await DisplayReporters(issues);
        Output.WriteLine();
        Output.WriteLine("and to the commenters who engaged in discussions and offered further insights:");
        Output.WriteLine();
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
        Output.WriteLine(listOfReporters);
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
        Output.WriteLine(listOfCommenters);

    }



    private static void DisplaySection(Options options, List<IssuePrItem> processedIssues, List<IssuePrItem> closedDoneIssues, string header, IEnumerable<string> searchTerms)
    {
        Output.WriteLine(header);
        Output.WriteLine();

        // Collect all matching issues across all search terms, remove duplicates, sort descending
        var sectionIssues = searchTerms
            .SelectMany(searchTerm => closedDoneIssues.Where(o => o.LabelStartsWith(searchTerm)))
            .DistinctBy(o => o.IssueId)
            .OrderByDescending(o => o.IssueId)
            .ToList();

        DisplayIssueList(sectionIssues, options);
        processedIssues.AddRange(sectionIssues);

        Output.WriteLine(sectionIssues.Count == 0 ? "None" : "");
    }

    static void DisplayIssueList(List<IssuePrItem> issues, Options options)
    {
        var url = $"https://github.com/{options.Organization}/{options.Repository}";
        foreach (var issue in issues)
        {
            string prText = "";
            if (issue.PrNumber > 0)
            {
                prText = PullRequestMentions(issue, url);
                prText = prText.Replace("<", "&lt;").Replace(">", "&gt;");
            }
            string title = issue.Title.Replace("<", "&lt;").Replace(">", "&gt;");
            Output.WriteLine(options.LinkIssues
                ? $"* [{issue.IssueId:####}]({url}/issues/{issue.IssueId}) {title} {prText}"
                : $"* {issue.IssueId:####} {issue.Title}");
        }
    }

    static string PullRequestMentions(IssuePrItem prItem, string url)
    {
        string[] teammembers = ["manfred-brands", "OsirisTerje", "stevenaw"];
        return teammembers.Contains(prItem.PrAuthorNick)
            ? $"Thanks to NUnit Team member [{prItem.PrAuthor}](https://github.com/{prItem.PrAuthorNick}) for [PR {prItem.PrNumber}]({url}/pull/{prItem.PrNumber})"
            : $"Thanks to [{prItem.PrAuthor}](https://github.com/{prItem.PrAuthorNick}) for [PR {prItem.PrNumber}]({url}/pull/{prItem.PrNumber})";
    }

    /// <summary>
    /// Displays breaking changes with their [!IMPORTANT] notes from the issue body
    /// </summary>
    static void DisplayBreakingChanges(Options options, List<IssuePrItem> issues)
    {
        Output.WriteLine("### The following issues are marked as breaking changes");
        Output.WriteLine();

        var url = $"https://github.com/{options.Organization}/{options.Repository}";
        var breakingIssues = issues.Where(o => o.LabelStartsWith("Breaking")).ToList();

        if (breakingIssues.Count == 0)
        {
            Output.WriteLine("None");
            return;
        }

        foreach (var issue in breakingIssues)
        {
            string prText = "";
            if (issue.PrNumber > 0)
            {
                prText = PullRequestMentions(issue, url);
                prText = prText.Replace("<", "&lt;").Replace(">", "&gt;");
            }
            string title = issue.Title.Replace("<", "&lt;").Replace(">", "&gt;");

            Output.WriteLine(options.LinkIssues
                ? $"* [{issue.IssueId:####}]({url}/issues/{issue.IssueId}) {title} {prText}"
                : $"* {issue.IssueId:####} {issue.Title}");

            // Check for [!IMPORTANT] content from the issue body or comments
            if (!string.IsNullOrEmpty(issue.ImportantNote))
            {
                Output.WriteLine();
                Output.WriteLine("  > [!IMPORTANT]");
                foreach (var line in issue.ImportantNote.Split('\n'))
                {
                    Output.WriteLine($"  > {line}");
                }
                Output.WriteLine();
            }
        }
    }

}
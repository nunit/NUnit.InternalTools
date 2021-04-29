using CommandLine;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alteridem.GetChanges
{
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
                Configure();
                return;
            }

            var github = new GitHubApi(options.Organization, options.Repository);

            var milestones = await github.GetOpenMilestones();

            foreach (var milestone in milestones.Where(m => m.DueOn != null && m.DueOn.Value.Subtract(DateTimeOffset.Now).TotalDays < 30))
            {
                var milestoneIssues = await github.GetClosedIssuesForMilestone(milestone);
                DisplayIssuesForMilestone(options, milestone.Title, milestoneIssues);
            }
        }

        static void DisplayIssuesForMilestone(Options options, string milestone, IEnumerable<Issue> issues)
        {
            Console.WriteLine("## {0}", milestone);
            Console.WriteLine();

            foreach (var issue in issues)
            {
                if (options.LinkIssues)
                    Console.WriteLine($"* [{issue.Number:####}](https://github.com/{options.Organization}/{options.Repository}/issues/{issue.Number}) {issue.Title}");
                else
                    Console.WriteLine($"* {issue.Number:####} {issue.Title}");
            }
            Console.WriteLine();
        }

        static void Configure()
        {
            Console.Write("Enter your GitHub API Token (See README.md): ");
            Secrets.Token = Console.ReadLine();
        }
    }
}

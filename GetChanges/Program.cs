using Nito.AsyncEx;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alteridem.GetChanges
{
    class Program
    {
        static int Main(string[] args)
        {
            var options = new Options();
            if (!CommandLine.Parser.Default.ParseArguments(args, options))
            {
                return -1;
            }

            AsyncContext.Run(() => MainAsync(options));

            //Console.WriteLine("*** Press ENTER to Exit ***");
            //Console.ReadLine();
            return 0;
        }

        static async void MainAsync(Options options)
        {
            var github = new GitHubApi(options.Organization, options.Repository);

            var milestones = await github.GetAllMilestones();
            var issues = await github.GetClosedIssues();

            //var noMilestoneIssues = from i in issues where i.Milestone == null select i;
            //DisplayIssuesForMilestone("Issues with no milestone", noMilestoneIssues);

            foreach (var milestone in milestones.Where(m => m.State == ItemState.Open && m.DueOn != null && m.DueOn.Value.Subtract(DateTimeOffset.Now).TotalDays < 30))
            {
                var milestoneIssues = from i in issues where i.Milestone != null && i.Milestone.Number == milestone.Number select i;
                DisplayIssuesForMilestone(options, milestone.Title, milestoneIssues);
            }
        }

        static void DisplayIssuesForMilestone(Options options, string milestone, IEnumerable<Issue> issues)
        {
            Console.WriteLine("## {0}", milestone);
            Console.WriteLine();

            foreach (var issue in issues)
            {
                if(options.LinkIssues)
                    Console.WriteLine($" * [{issue.Number:####}](https://github.com/{options.Repository}/{options.Repository}/issues/{issue.Number}) {issue.Title}");
                else
                    Console.WriteLine($" * {issue.Number:####} {issue.Title}");
            }
            Console.WriteLine();
        }
    }
}

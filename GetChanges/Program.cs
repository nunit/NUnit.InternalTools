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
                Console.WriteLine(options.GetUsage());
                return -1;
            }

            AsyncContext.Run(() => MainAsync(options));

            Console.WriteLine("*** Press ENTER to Exit ***");
            Console.ReadLine();
            return 0;
        }

        static async void MainAsync(Options options)
        {
            var github = new GitHubApi("nunit", "nunit");

            var milestones = await github.GetAllMilestones();
            var issues = await github.GetClosedIssues();

            var noMilestoneIssues = from i in issues where i.Milestone == null select i;
            DisplayIssuesForMilestone("Issues with no milestone", noMilestoneIssues);

            foreach (var milestone in milestones)
            {
                var milestoneIssues = from i in issues where i.Milestone != null && i.Milestone.Number == milestone.Number select i;
                DisplayIssuesForMilestone(milestone.Title, milestoneIssues);
            }
        }

        static void DisplayIssuesForMilestone(string milestone, IEnumerable<Issue> issues)
        {
            Console.WriteLine("## {0}", milestone);
            Console.WriteLine();

            foreach (var issue in issues)
            {
                Console.WriteLine(" * {0:####} {1}", issue.Number, issue.Title);
            }
            Console.WriteLine();
        }
    }
}

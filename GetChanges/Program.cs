using Nito.AsyncEx;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alteridem.GetChanges
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncContext.Run(() => MainAsync(args));
            Console.WriteLine("*** Press ENTER to Exit ***");
            Console.ReadLine();
        }

        static async void MainAsync(string[] args)
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

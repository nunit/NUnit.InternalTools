using Nito.AsyncEx;
using System;
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
            foreach (var milestone in milestones)
            {
                Console.WriteLine("### {0} - {1}", milestone.Title, milestone.DueOn.HasValue ? milestone.DueOn.Value.ToString() : "");
                Console.WriteLine();

                var milestoneIssues = from i in issues where i.Milestone != null && i.Milestone.Number == milestone.Number select i;
                foreach(var issue in milestoneIssues)
                {
                    Console.WriteLine(" - {0} {1}", issue.Number, issue.Title);
                }
                Console.WriteLine();
            }
        }
    }
}

using Nito.AsyncEx;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetChanges
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
            var github = new GitHubClient(new ProductHeaderValue("GetChangeset"));

            var request = new MilestoneRequest();
            request.State = ItemState.All;
            request.SortProperty = MilestoneSort.DueDate;
            request.SortDirection = SortDirection.Descending;
            try
            {
                var milestones = await github.Issue.Milestone.GetAllForRepository("nunit", "nunit", request);
                foreach (var milestone in milestones)
                {
                    Console.WriteLine("### {0} - {1}", milestone.Title, milestone.DueOn.HasValue ? milestone.DueOn.Value.ToString() : "");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to get milestones for repository, {0}", ex.Message);
            }
        }
    }
}

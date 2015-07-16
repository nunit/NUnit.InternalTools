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

    internal class GitHubApi
    {
        GitHubClient _github = new GitHubClient(new ProductHeaderValue("Alteridem.GetChangeset"));
        string _organization;
        string _repository;

        /// <summary>
        /// Constructs a class for talking to GitHub
        /// </summary>
        /// <param name="organization">The organization you are interested in</param>
        /// <param name="repository">The repository within an organization</param>
        public GitHubApi(string organization, string repository)
        {
            _organization = organization;
            _repository = repository;
        }

        public async Task<IReadOnlyList<Milestone>> GetAllMilestones()
        {
            var request = new MilestoneRequest();
            request.State = ItemState.All;
            request.SortProperty = MilestoneSort.DueDate;
            request.SortDirection = SortDirection.Descending;
            try
            {
                return await _github.Issue.Milestone.GetAllForRepository(_organization, _repository, request);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to get milestones for repository, {0}", ex.Message);
            }
            return new List<Milestone>();
        }

        public async Task<IReadOnlyList<Issue>> GetClosedIssues()
        {
            var request = new RepositoryIssueRequest();
            request.State = ItemState.Closed;
            request.SortProperty = IssueSort.Created;
            request.SortDirection = SortDirection.Ascending;
            try
            {
                return await _github.Issue.GetAllForRepository(_organization, _repository, request);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to get issues for repository, {0}", ex.Message);
            }
            return new List<Issue>();
        }
    }
}

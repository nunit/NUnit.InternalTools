using Octokit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alteridem.GetChanges
{
    /// <summary>
    /// A simple class for communicating with GitHub
    /// </summary>
    internal class GitHubApi
    {
        GitHubClient _github;
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
            _github = new GitHubClient(new ProductHeaderValue("Alteridem.GetChangeset"));
            _github.Credentials = new Credentials(Secrets.Token);
        }

        public async Task<IReadOnlyList<Milestone>> GetOpenMilestones()
        {
            var request = new MilestoneRequest();
            request.State = ItemStateFilter.Open;
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

        public async Task<IReadOnlyList<Issue>> GetClosedIssuesForMilestone(Milestone milestone)
        {
            var request = new RepositoryIssueRequest();
            request.State = ItemStateFilter.Closed;
            request.SortProperty = IssueSort.Created;
            request.SortDirection = SortDirection.Ascending;
            request.Milestone = milestone.Number.ToString();
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

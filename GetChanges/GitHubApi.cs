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
        private readonly GitHubClient _github;
        private readonly string _organization;
        private readonly string _repository;

        /// <summary>
        /// Constructs a class for talking to GitHub
        /// </summary>
        /// <param name="organization">The organization you are interested in</param>
        /// <param name="repository">The repository within an organization</param>
        public GitHubApi(string organization, string repository)
        {
            _organization = organization;
            _repository = repository;
            _github = new GitHubClient(new ProductHeaderValue("Alteridem.GetChangeset"))
            {
                Credentials = new Credentials(Secrets.Token)
            };
        }

        public async Task<IReadOnlyList<Milestone>> GetOpenMilestones()
        {
            var request = new MilestoneRequest
            {
                State = ItemStateFilter.Open,
                SortProperty = MilestoneSort.DueDate,
                SortDirection = SortDirection.Descending
            };
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
            var request = new RepositoryIssueRequest
            {
                State = ItemStateFilter.Closed,
                SortProperty = IssueSort.Created,
                SortDirection = SortDirection.Descending,
                Milestone = milestone.Number.ToString()
            };
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

        /// <summary>
        /// Actually gets either pull requests or issues by id
        /// </summary>
        public async Task<Issue> GetIssueOrPulLRequest(int id)
        {
            try
            {
                var pr = await _github.Issue.Get(_organization, _repository, id);
                return pr;

            }
            catch (ApiException e)
            {
                Console.WriteLine($"Could not get Id={id}, exception: {e}");
                throw;
            }
        }

        public async Task<User> GetUser(string login)
        {
            var user = await _github.User.Get(login);
            return user;
        }
    }
}

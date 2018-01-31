using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using help.api.models;

namespace help.api.services.IssueTracking
{
    public class IssueService : IIssueService
    {
        public Task CreateIssueAsync(Issue issue)
        {
            return Task.FromResult<bool>(true);
        }

        public Task DeleteAsync(int id)
        {
            return Task.FromResult<bool>(true);
        }

        public Task<IEnumerable<Issue>> GetAllIssuesAsync()
        {
            return Task.Run<IEnumerable<Issue>>(() => { return new List<Issue>(); });
        }

        public Task<Issue> GetIssueByIdAsync(int id)
        {
            return Task.Run<Issue>(() => new Issue());
        }

        public Task UpdateIssueAsync(int id, Issue issue)
        {
            throw new NotImplementedException();
        }
    }
}

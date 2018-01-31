using help.api.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.api.services.IssueTracking
{
    public interface IIssueService
    {
        Task CreateIssueAsync(Issue issue);

        Task UpdateIssueAsync(int id, Issue issue);

        Task DeleteAsync(int id);

        Task<Issue> GetIssueByIdAsync(int id);

        Task<IEnumerable<Issue>> GetAllIssuesAsync();
    }
}

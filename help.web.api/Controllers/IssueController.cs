using help.api.models;
using help.api.services.IssueTracking;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace help.web.api.Controllers
{
    [RoutePrefix("api/issue")]
    public class IssueController : ApiController
    {
        private readonly IIssueService issueService;
        public IssueController(IIssueService issueService)
        {
            this.issueService = issueService;
        }

        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<Issue>> GetIssues() {

            return await issueService.GetAllIssuesAsync();
            
        }
    }
}

using help.api.models;
using help.api.services.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace help.web.api.Controllers
{
    [RoutePrefix("api/status")]
    public class StatusController : ApiController
    {

        private readonly IStatusService statusService;

        public StatusController(IStatusService statusService)
        {
            this.statusService = statusService;
        }
        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<Status>> GetStatuses() {
            return await statusService.GetStatuses();

        }
    }
}

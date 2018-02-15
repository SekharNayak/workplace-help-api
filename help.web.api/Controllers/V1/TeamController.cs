using help.api.models;
using help.api.services.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace help.web.api.Controllers.V1
{

    [RoutePrefix("api/V1/team")]
    public class TeamController : ApiController
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService teamService )
        {
            this.teamService = teamService;
        }

        [Route("")]
        [HttpGet]
        public async  Task<IEnumerable<Team>> Get() {
            return await teamService.GetTeams();
        }

        [Route("{Id}/users")]
        [HttpGet]
        public async Task<IEnumerable<User>> GetUsersByTeam(int Id)
        {
            return await teamService.GetUsersByTeamId(Id);
        }

    }
}
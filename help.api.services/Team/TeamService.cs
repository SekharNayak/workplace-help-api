using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using help.api.models;
using help.api.repositories;

namespace help.api.services.Team
{
    public class TeamService : ITeamService
    {

        private readonly ITeamRepository teamRepo;


        public TeamService(ITeamRepository teamRepo )
        {
            this.teamRepo = teamRepo;
        }
        public Task<IEnumerable<models.Team>> GetTeams()
        {
            return Task.Run<IEnumerable<models.Team>>(() => {
                return teamRepo.Get();
            });
        }

        public Task<IEnumerable<User>> GetUsersByTeamId(int Id)
        {
            return Task.Run<IEnumerable<models.User>>(() => {
                return teamRepo.GetUsersByTeam(Id);
            });
        }
    }
}

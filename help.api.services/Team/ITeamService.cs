using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.api.services.Team
{
    public interface ITeamService
    {
        Task<IEnumerable<api.models.Team>> GetTeams();


        Task<IEnumerable<models.User>> GetUsersByTeamId(int Id);
    }
}

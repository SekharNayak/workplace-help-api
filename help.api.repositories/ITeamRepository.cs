using help.api.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.api.repositories
{
    public interface ITeamRepository : IRepository<Team>
    {
        IEnumerable<User> GetUsersByTeam(int Id);
    }
}

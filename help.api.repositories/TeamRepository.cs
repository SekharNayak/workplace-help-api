using help.api.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.api.repositories
{
   public class TeamRepository : BaseRepository<Team> , ITeamRepository
    {
        public TeamRepository(DbContext context )
            :base(context)
        {

        }

        public IEnumerable<User> GetUsersByTeam(int Id)
        {
            return dbContext.Set<Team>().Where(team => team.Id == Id).
                            Select(team => team.Users).FirstOrDefault();
           
        }
    }
}

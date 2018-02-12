using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.api.repositories
{
    public class StatusRepository : BaseRepository<help.api.models.Status> , IStatusRepository
    {
        public StatusRepository(DbContext context)
            : base(context)
        {

        }
    }
}

using help.api.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using help.db;

namespace help.api.repositories
{
    public class IssueRepository : BaseRepository<Issue>, IIssueRepository
    {
        
        public IssueRepository(HelpDeskContext dbContext) : base(dbContext)
        {
            
        }
    }
}

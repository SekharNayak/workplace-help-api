using help.api.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.db
{
    public class HelpDeskContext : DbContext
    {
        public HelpDeskContext():base("name=HelpDBConnection")
        {

        }


        public DbSet<Issue> Issues { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<AttachedItem> Attachments { get; set; }

        public DbSet<WorkNote> WorkNotes { get; set; }
    }
}

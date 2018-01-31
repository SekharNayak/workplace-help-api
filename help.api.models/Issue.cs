using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.api.models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Subject { get; set; }

        public string Description { get; set; }

        public int CreatedBy { get; set; }

        public Status Status { get; set; }

        public string CurrentStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public Team AssignedTeam { get; set; }

        public User AssignedTo { get; set; }

        public IList<WorkNote> WorkNotes { get; set; }

    }
}
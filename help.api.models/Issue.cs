using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace help.api.models
{
    public class Issue
    {
        public int Id { get; set; }

        [Required]
        public string Subject { get; set; }

        public string Description { get; set; }

        [Required]
        public int CreatedBy { get; set; }
        
        public Status Status { get; set; }
        [Required]
        public string CurrentStatus { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public Team AssignedTeam { get; set; }

        public User AssignedTo { get; set; }

        public IList<WorkNote> WorkNotes { get; set; }

    }
}
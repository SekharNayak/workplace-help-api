using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace help.api.models
{
    public class WorkNote
    {
        public Guid WorkNoteId { get; set; }

        [Required]
        public string Note { get; set; }

        public string Description { get; set; }
        [Required]
        public int CreatedBy { get; set; }

        public IList<AttachedItem> Attachments { get; set; }
    }
}

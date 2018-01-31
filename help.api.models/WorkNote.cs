using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.api.models
{
    public class WorkNote
    {
        public Guid WorkNoteId { get; set; }

        public string Note { get; set; }

        public string Description { get; set; }

        public int CreatedBy { get; set; }

        public IList<AttachedItem> Attachments { get; set; }
    }
}

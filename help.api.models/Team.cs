using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.api.models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<User> Users { get; set; }
    }
}

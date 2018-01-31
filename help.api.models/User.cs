using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.api.models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public int EmployeeId { get; set; }

        public IList<Team> Teams { get; set; }

    }
}

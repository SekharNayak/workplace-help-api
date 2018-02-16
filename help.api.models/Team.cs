using System.Collections.Generic;

namespace help.api.models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<User> Users { get; set; }
    }
}

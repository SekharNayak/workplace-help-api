

namespace help.api.models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public class User
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression("")]
        public string Email { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public IList<Team> Teams { get; set; }

    }
}

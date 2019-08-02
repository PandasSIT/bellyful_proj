using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class VolunteerRole
    {
        public VolunteerRole()
        {
            Volunteer = new HashSet<Volunteer>();
        }

        public byte RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<Volunteer> Volunteer { get; set; }
    }
}

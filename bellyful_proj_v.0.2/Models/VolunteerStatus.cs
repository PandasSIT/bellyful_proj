using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class VolunteerStatus
    {
        public VolunteerStatus()
        {
            Volunteer = new HashSet<Volunteer>();
        }

        public byte StatusId { get; set; }
        public string Content { get; set; }

        public ICollection<Volunteer> Volunteer { get; set; }
    }
}

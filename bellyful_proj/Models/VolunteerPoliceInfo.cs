using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class VolunteerPoliceInfo
    {
        public int VolunteerId { get; set; }
        public DateTime PoliceVetDate { get; set; }
        public byte PoliceVetVerified { get; set; }

        public Volunteer Volunteer { get; set; }
    }
}

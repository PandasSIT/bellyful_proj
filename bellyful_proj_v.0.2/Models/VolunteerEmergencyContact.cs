using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class VolunteerEmergencyContact
    {
        public int VolunteerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Relationship { get; set; }

        public Volunteer Volunteer { get; set; }
    }
}

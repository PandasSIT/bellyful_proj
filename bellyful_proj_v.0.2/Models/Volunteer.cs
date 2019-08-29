using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class Volunteer
    {
        public Volunteer()
        {
            Order = new HashSet<Order>();
        }

        public int VolunteerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string PreferredPhone { get; set; }
        public string AlternativePhone { get; set; }
        public string Address { get; set; }
        public string TownCity { get; set; }
        public string PostCode { get; set; }
        public byte? StatusId { get; set; }
        public int? BranchBelonged { get; set; }
        public byte? RoleId { get; set; }

        public Branch BranchBelongedNavigation { get; set; }
        public VolunteerRole Role { get; set; }
        public VolunteerStatus Status { get; set; }
        public VolunteerEmergencyContact VolunteerEmergencyContact { get; set; }
        public VolunteerPoliceInfo VolunteerPoliceInfo { get; set; }
        public VolunteerTrainingInfo VolunteerTrainingInfo { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}

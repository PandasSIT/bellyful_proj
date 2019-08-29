using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Recipient = new HashSet<Recipient>();
            Volunteer = new HashSet<Volunteer>();
        }

        public int BranchId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressNumStreet { get; set; }
        public string TownCity { get; set; }

        public ICollection<Recipient> Recipient { get; set; }
        public ICollection<Volunteer> Volunteer { get; set; }
    }
}

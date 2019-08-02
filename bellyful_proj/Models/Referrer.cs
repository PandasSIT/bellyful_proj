using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class Referrer
    {
        public Referrer()
        {
            Recipient = new HashSet<Recipient>();
        }

        public int ReferrerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OrganisationName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string TownCity { get; set; }
        public byte ReferringAs { get; set; }

        public ReferrerRole ReferringAsNavigation { get; set; }
        public ICollection<Recipient> Recipient { get; set; }
    }
}

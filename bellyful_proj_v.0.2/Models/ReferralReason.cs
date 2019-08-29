using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class ReferralReason
    {
        public ReferralReason()
        {
            Recipient = new HashSet<Recipient>();
        }

        public byte ReferralReasonId { get; set; }
        public string Content { get; set; }

        public ICollection<Recipient> Recipient { get; set; }
    }
}

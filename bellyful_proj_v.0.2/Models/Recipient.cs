using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class Recipient
    {
        public Recipient()
        {
            Order = new HashSet<Order>();
        }

        public int RecipientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressNumStreet { get; set; }
        public string TownCity { get; set; }
        public int? Postcode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte? DogOnProperty { get; set; }
        public int NearestBranch { get; set; }
        public byte ReferralReason { get; set; }
        public string OtherReferralInfo { get; set; }
        public byte AdultsNum { get; set; }
        public byte Under5ChildrenNum { get; set; }
        public byte _510ChildrenNum { get; set; }
        public byte _1117ChildrenNum { get; set; }
        public byte? DietaryRequirement { get; set; }
        public string OtherAllergyInfo { get; set; }
        public string AdditionalInfo { get; set; }
        public int? ReferrerId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public DietaryRequirement DietaryRequirementNavigation { get; set; }
        public Branch NearestBranchNavigation { get; set; }
        public ReferralReason ReferralReasonNavigation { get; set; }
        public Referrer Referrer { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class DietaryRequirement
    {
        public DietaryRequirement()
        {
            Recipient = new HashSet<Recipient>();
        }

        public byte DietaryRequirementId { get; set; }
        public string DietaryName { get; set; }
        public string MatchedSetMeal { get; set; }
        public string Description { get; set; }

        public ICollection<Recipient> Recipient { get; set; }
    }
}

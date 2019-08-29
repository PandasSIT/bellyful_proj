using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class Batch
    {
        public int BatchId { get; set; }
        public int AddAmount { get; set; }
        public DateTime ProductionDate { get; set; }
        public byte MealTypeId { get; set; }

        public MealType MealType { get; set; }
    }
}

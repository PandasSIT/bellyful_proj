using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class MealInstock
    {
        public byte MealTypeId { get; set; }
        public int InstockAmount { get; set; }

        public MealType MealType { get; set; }
    }
}

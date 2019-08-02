using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class MealType
    {
        public MealType()
        {
            Batch = new HashSet<Batch>();
        }

        public byte MealTypeId { get; set; }
        public string MealTypeName { get; set; }
        public string ShelfLocation { get; set; }

        public MealInstock MealInstock { get; set; }
        public ICollection<Batch> Batch { get; set; }
    }
}

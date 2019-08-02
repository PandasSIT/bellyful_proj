using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Order = new HashSet<Order>();
        }

        public byte StatusId { get; set; }
        public string Content { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}

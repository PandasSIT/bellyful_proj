using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public byte? StatusId { get; set; }
        public int? DeliveryMan { get; set; }
        public int RecipientId { get; set; }
        public DateTime? CreatedDatetime { get; set; }
        public DateTime? AssignDatetime { get; set; }
        public DateTime? PickupDatetime { get; set; }
        public DateTime? DeliveredDatetime { get; set; }

        public Volunteer DeliveryManNavigation { get; set; }
        public Recipient Recipient { get; set; }
        public OrderStatus Status { get; set; }
    }
}

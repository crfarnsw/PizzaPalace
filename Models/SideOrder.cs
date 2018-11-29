using System;
using System.Collections.Generic;

namespace PizzaPalace.Models
{
    public partial class SideOrder
    {
        public int SideOrderId { get; set; }
        public int OrderItemId { get; set; }
        public int SideId { get; set; }

        public OrderItem OrderItem { get; set; }
        public Side Side { get; set; }
    }
}

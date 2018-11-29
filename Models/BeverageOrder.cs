using System;
using System.Collections.Generic;

namespace PizzaPalace.Models
{
    public partial class BeverageOrder
    {
        public int BeverageOrderId { get; set; }
        public int OrderItemId { get; set; }
        public int BeverageId { get; set; }

        public Beverage Beverage { get; set; }
        public OrderItem OrderItem { get; set; }
    }
}

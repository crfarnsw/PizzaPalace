using System;
using System.Collections.Generic;

namespace PizzaPalace.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            BeverageOrder = new HashSet<BeverageOrder>();
            PizzaOrder = new HashSet<PizzaOrder>();
            SideOrder = new HashSet<SideOrder>();
        }

        public int OrderItemId { get; set; }
        public int OrderId { get; set; }

        public Orders Order { get; set; }
        public ICollection<BeverageOrder> BeverageOrder { get; set; }
        public ICollection<PizzaOrder> PizzaOrder { get; set; }
        public ICollection<SideOrder> SideOrder { get; set; }
    }
}

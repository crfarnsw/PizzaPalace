using System;
using System.Collections.Generic;

namespace PizzaPalace.Models
{
    public partial class PizzaOrder
    {
        public PizzaOrder()
        {
            PizzaToppings = new HashSet<PizzaToppings>();
        }

        public int PizzaOrderId { get; set; }
        public int OrderItemId { get; set; }
        public int PizzaId { get; set; }

        public OrderItem OrderItem { get; set; }
        public Pizza Pizza { get; set; }
        public ICollection<PizzaToppings> PizzaToppings { get; set; }
    }
}

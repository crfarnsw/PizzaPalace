using System;
using System.Collections.Generic;

namespace PizzaPalace.Models
{
    public partial class PizzaToppings
    {
        public int PizzaToppingId { get; set; }
        public int ToppingId { get; set; }
        public int PizzaOrderId { get; set; }

        public PizzaOrder PizzaOrder { get; set; }
        public Toppings Topping { get; set; }
    }
}

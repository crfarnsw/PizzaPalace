using System;
using System.Collections.Generic;

namespace PizzaPalace.Models
{
    public partial class Toppings
    {
        public Toppings()
        {
            PizzaToppings = new HashSet<PizzaToppings>();
        }

        public int ToppingId { get; set; }
        public string ToppingName { get; set; }
        public decimal? ToppingPrice { get; set; }

        public ICollection<PizzaToppings> PizzaToppings { get; set; }
    }
}

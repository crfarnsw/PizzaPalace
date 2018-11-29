using System;
using System.Collections.Generic;

namespace PizzaPalace.Models
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
        }

        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public string PizzaDescription { get; set; }
        public decimal? PizzaPrice { get; set; }

        public ICollection<PizzaOrder> PizzaOrder { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PizzaPalace.Models
{
    public partial class Beverage
    {
        public Beverage()
        {
            BeverageOrder = new HashSet<BeverageOrder>();
        }

        public int BeverageId { get; set; }
        public string BeverageName { get; set; }
        public decimal? BeveragePrice { get; set; }

        public ICollection<BeverageOrder> BeverageOrder { get; set; }
    }
}

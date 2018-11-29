using System;
using System.Collections.Generic;

namespace PizzaPalace.Models
{
    public partial class Side
    {
        public Side()
        {
            SideOrder = new HashSet<SideOrder>();
        }

        public int SideId { get; set; }
        public string SideName { get; set; }
        public decimal? SidePrice { get; set; }

        public ICollection<SideOrder> SideOrder { get; set; }
    }
}

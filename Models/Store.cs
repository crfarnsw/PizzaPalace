using System;
using System.Collections.Generic;

namespace PizzaPalace.Models
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Orders>();
        }

        public int StoreId { get; set; }
        public string StorePhoneNumber { get; set; }
        public string StoreAddress { get; set; }
        public string StoreCity { get; set; }
        public string StoreZip { get; set; }
        public string StoreState { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}

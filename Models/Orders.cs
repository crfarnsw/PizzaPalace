using System;
using System.Collections.Generic;

namespace PizzaPalace.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public DateTime? OrderDate { get; set; }

        public Customers Customer { get; set; }
        public Store Store { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}

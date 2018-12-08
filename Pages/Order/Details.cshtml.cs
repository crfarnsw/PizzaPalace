using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaPalace.Models;
using System.Threading.Tasks;

namespace PizzaPalace.Pages.Order
{
    using System.Collections.Generic;
    using System.Linq;

    using Pizza = PizzaPalace.Models.Pizza;
    using PizzaOrder = PizzaPalace.Models.PizzaOrder;

    public class DetailsModel : PageModel
    {
        private readonly PizzaPalacedbContext _context;

        public DetailsModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IList<Orders> OrdersList { get; set; }

        public Orders Orders { get; set; }
        public OrderItem OrderItem { get; set; }

        public List<Pizza> Pizza { get; set; }
        public List<PizzaOrder> PizzaOrder { get; set; }
        public List<Toppings> Toppings { get; set; }

        public List<Beverage> Beverages { get; set; }
        public List<BeverageOrder> BeverageOrders { get; set; }

        public List<Side> Sides { get; set; }
        public List<SideOrder> SideOrders { get; set; }

        public string name { get; set; }

        /// <summary>
        /// On HTTPGet retrieve any objects associated with the OrderId and orderitem and set them here.
        /// </summary>
        /// <param name="OrderId"></param>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public async Task<IActionResult> OnGetAsync(int? OrderId, int? orderItemId)
        {
            if (OrderId == null)
            {
                return NotFound();
            }

            var identity = User.Identity;
            name = identity.Name;

            // All queries written in LINQ Here is an example SQL query of the below LINQ for reference 
            // SELECT * FROM Orders order
            // LEFT JOIN Customer customer on order.CustomerId = customer.CustomerId
            // LEFT JOIN OrderItem item on order.OrderId = item.OrderId
            // LEFT JOIN Store store on order.StoreId=Store.StoreId
            // WHERE @OrderId=o.OrderId
            Orders = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderItem)
                .Include(o => o.Store).FirstOrDefaultAsync(m => m.OrderId == OrderId);

            OrderItem = await _context.OrderItem
                .Include(o => o.PizzaOrder)
                .Include(o => o.BeverageOrder)
                .Include(o => o.SideOrder).FirstOrDefaultAsync(m => m.OrderId == OrderId);

            Pizza = await _context.Pizza.ToListAsync();

            PizzaOrder = await _context.PizzaOrder
                .Include(p => p.PizzaToppings)
                .Where(p => p.OrderItemId == orderItemId).ToListAsync();

            Toppings = await _context.Toppings.ToListAsync();

            Beverages = await _context.Beverage.ToListAsync();
            BeverageOrders = await _context.BeverageOrder.Where(o => o.OrderItemId == orderItemId).ToListAsync();

            Sides = await _context.Side.ToListAsync();
            SideOrders = await _context.SideOrder.Where(s => s.OrderItemId == orderItemId).ToListAsync();

            if (Orders == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int OrderItemId)
        {
            return Page();
        }
    }
}

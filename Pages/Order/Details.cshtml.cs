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

        public Orders Orders { get; set; }
        public OrderItem OrderItem { get; set; }
        public List<Pizza> Pizza { get; set; }
        public IList<Orders> OrdersList { get; set; }

        public string name { get; set; }

        public async Task<IActionResult> OnGetAsync(int? OrderId, int? orderItemId)
        {
            if (OrderId == null)
            {
                return NotFound();
            }
            
            var identity = User.Identity;
            name = identity.Name;

            Orders = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderItem)
                .Include(o => o.Store).FirstOrDefaultAsync(m => m.OrderId == OrderId);

            OrderItem = await _context.OrderItem
                            .Include(o => o.PizzaOrder)
                            .Include(o => o.BeverageOrder)
                            .Include(o => o.SideOrder).FirstOrDefaultAsync(m => m.OrderId == OrderId);

            Pizza = await _context.Pizza.ToListAsync();

            if (Orders == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int OrderItemId)
        {
            int pizzaId = 0;

            PizzaOrder pizzaOrder = new PizzaOrder
            {
                PizzaId = pizzaId,
                OrderItemId = OrderItemId
            };

            _context.PizzaOrder.Add(pizzaOrder);
            _context.SaveChanges();

            return Page();
        }
    }
}

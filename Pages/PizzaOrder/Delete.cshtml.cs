using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.PizzaOrder
{
    using PizzaOrder = Models.PizzaOrder;

    public class DeleteModel : PageModel
    {
        private readonly PizzaPalacedbContext _context;

        public DeleteModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PizzaOrder PizzaOrder { get; set; }

        /// <summary>
        /// HTTP GET Get the PizzaOrder which we are deleting.
        /// </summary>
        public async Task<IActionResult> OnGetAsync(int OrderId, int OrderItemId, int PizzaOrderId)
        {
            PizzaOrder = await _context.PizzaOrder
                .Include(p => p.OrderItem)
                .Include(p => p.Pizza).FirstOrDefaultAsync(m => m.PizzaOrderId == PizzaOrderId);

            if (PizzaOrder == null)
            {
                return NotFound();
            }
            return Page();
        }
        
        /// <summary>
        /// HTTP POST Delete the PizzaOrder and redirect to the OrderDetails page.
        /// </summary>
        public async Task<IActionResult> OnPostAsync(int OrderId, int OrderItemId, int PizzaOrderId)
        {
            PizzaOrder = await _context.PizzaOrder.FindAsync(PizzaOrderId);

            if (PizzaOrder != null)
            {
                _context.PizzaOrder.Remove(PizzaOrder);
                await _context.SaveChangesAsync();
            }

            return Redirect($"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.BeverageOrders
{
    public class DeleteModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public DeleteModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BeverageOrder BeverageOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int OrderId, int OrderItemId, int BeverageOrderId)
        {
            BeverageOrder = await _context.BeverageOrder
                .Include(b => b.Beverage)
                .Include(b => b.OrderItem).FirstOrDefaultAsync(m => m.BeverageOrderId == BeverageOrderId);

            if (BeverageOrder == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int OrderId, int OrderItemId, int BeverageOrderId)
        {
            BeverageOrder = await _context.BeverageOrder.FindAsync(BeverageOrderId);

            if (BeverageOrder != null)
            {
                _context.BeverageOrder.Remove(BeverageOrder);
                await _context.SaveChangesAsync();
            }

            return Redirect($"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}");
        }
    }
}

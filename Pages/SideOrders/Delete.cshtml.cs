using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.SideOrders
{
    public class DeleteModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public DeleteModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SideOrder SideOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int OrderId, int OrderItemId, int SideOrderId)
        {
            SideOrder = await _context.SideOrder
                .Include(s => s.OrderItem)
                .Include(s => s.Side).FirstOrDefaultAsync(m => m.SideOrderId == SideOrderId);

            if (SideOrder == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int OrderId, int OrderItemId, int SideOrderId)
        {
            SideOrder = await _context.SideOrder.FindAsync(SideOrderId);

            if (SideOrder != null)
            {
                _context.SideOrder.Remove(SideOrder);
                await _context.SaveChangesAsync();
            }

            return Redirect($"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}");
        }
    }
}

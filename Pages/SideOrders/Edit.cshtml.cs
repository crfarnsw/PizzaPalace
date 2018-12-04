using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.SideOrders
{
    public class EditModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public EditModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SideOrder SideOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SideOrder = await _context.SideOrder
                .Include(s => s.OrderItem)
                .Include(s => s.Side).FirstOrDefaultAsync(m => m.SideOrderId == id);

            if (SideOrder == null)
            {
                return NotFound();
            }
           ViewData["OrderItemId"] = new SelectList(_context.OrderItem, "OrderItemId", "OrderItemId");
           ViewData["SideId"] = new SelectList(_context.Side, "SideId", "SideId");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SideOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SideOrderExists(SideOrder.SideOrderId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SideOrderExists(int id)
        {
            return _context.SideOrder.Any(e => e.SideOrderId == id);
        }
    }
}

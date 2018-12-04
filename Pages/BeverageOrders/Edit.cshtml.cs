using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.BeverageOrders
{
    public class EditModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public EditModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BeverageOrder BeverageOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BeverageOrder = await _context.BeverageOrder
                .Include(b => b.Beverage)
                .Include(b => b.OrderItem).FirstOrDefaultAsync(m => m.BeverageOrderId == id);

            if (BeverageOrder == null)
            {
                return NotFound();
            }
           ViewData["BeverageId"] = new SelectList(_context.Beverage, "BeverageId", "BeverageId");
           ViewData["OrderItemId"] = new SelectList(_context.OrderItem, "OrderItemId", "OrderItemId");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BeverageOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeverageOrderExists(BeverageOrder.BeverageOrderId))
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

        private bool BeverageOrderExists(int id)
        {
            return _context.BeverageOrder.Any(e => e.BeverageOrderId == id);
        }
    }
}

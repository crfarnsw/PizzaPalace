using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.PizzaOrder
{
    using PizzaOrder = PizzaPalace.Models.PizzaOrder;

    public class EditModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public EditModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PizzaOrder PizzaOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PizzaOrder = await _context.PizzaOrder
                .Include(p => p.OrderItem)
                .Include(p => p.Pizza).FirstOrDefaultAsync(m => m.PizzaOrderId == id);

            if (PizzaOrder == null)
            {
                return NotFound();
            }
           ViewData["OrderItemId"] = new SelectList(_context.OrderItem, "OrderItemId", "OrderItemId");
           ViewData["PizzaId"] = new SelectList(_context.Pizza, "PizzaId", "PizzaId");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PizzaOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaOrderExists(PizzaOrder.PizzaOrderId))
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

        private bool PizzaOrderExists(int id)
        {
            return _context.PizzaOrder.Any(e => e.PizzaOrderId == id);
        }
    }
}

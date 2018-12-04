using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.PizzaToppings
{
    using PizzaToppings = PizzaPalace.Models.PizzaToppings;

    public class EditModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public EditModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PizzaToppings PizzaToppings { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PizzaToppings = await _context.PizzaToppings
                .Include(p => p.PizzaOrder)
                .Include(p => p.Topping).FirstOrDefaultAsync(m => m.PizzaToppingId == id);

            if (PizzaToppings == null)
            {
                return NotFound();
            }
           ViewData["PizzaOrderId"] = new SelectList(_context.PizzaOrder, "PizzaOrderId", "PizzaOrderId");
           ViewData["ToppingId"] = new SelectList(_context.Toppings, "ToppingId", "ToppingId");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PizzaToppings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaToppingsExists(PizzaToppings.PizzaToppingId))
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

        private bool PizzaToppingsExists(int id)
        {
            return _context.PizzaToppings.Any(e => e.PizzaToppingId == id);
        }
    }
}

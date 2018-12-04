using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.PizzaToppings
{
    using PizzaToppings = PizzaPalace.Models.PizzaToppings;

    public class DeleteModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public int _OrderId { get; set; }
        public int _OrderItemId { get; set; }
        public int _PizzaToppingId { get; set; }

        public DeleteModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PizzaToppings PizzaToppings { get; set; }

        public async Task<IActionResult> OnGetAsync(int OrderId, int OrderItemId, int PizzaToppingId)
        {
            PizzaToppings = await _context.PizzaToppings
                .Include(p => p.PizzaOrder)
                .Include(p => p.Topping).FirstOrDefaultAsync(m => m.PizzaToppingId == PizzaToppingId);

            _OrderId = OrderId;
            _OrderItemId = OrderItemId;

            if (PizzaToppings == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int OrderId, int OrderItemId, int PizzaToppingId)
        {
            PizzaToppings = await _context.PizzaToppings.FindAsync(PizzaToppingId);

            if (PizzaToppings != null)
            {
                _context.PizzaToppings.Remove(PizzaToppings);
                await _context.SaveChangesAsync();
            }

            return Redirect($"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}");
        }
    }
}

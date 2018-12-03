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
    using PizzaOrder = PizzaPalace.Models.PizzaOrder;

    public class DetailsModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public DetailsModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}

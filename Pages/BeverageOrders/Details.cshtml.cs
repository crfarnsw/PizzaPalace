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
    public class DetailsModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public DetailsModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}

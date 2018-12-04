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
    public class DetailsModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public DetailsModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}

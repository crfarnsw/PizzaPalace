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
    public class IndexModel : PageModel
    {
        private readonly PizzaPalacedbContext _context;

        public IndexModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IList<SideOrder> SideOrder { get;set; }

        public async Task OnGetAsync()
        {
            SideOrder = await _context.SideOrder
                .Include(s => s.OrderItem)
                .Include(s => s.Side).ToListAsync();
        }
    }
}

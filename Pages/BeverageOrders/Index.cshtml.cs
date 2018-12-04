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
    public class IndexModel : PageModel
    {
        private readonly PizzaPalacedbContext _context;

        public IndexModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IList<BeverageOrder> BeverageOrder { get;set; }

        public async Task OnGetAsync()
        {
            BeverageOrder = await _context.BeverageOrder
                .Include(b => b.Beverage)
                .Include(b => b.OrderItem).ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.Order
{
    public class IndexModel : PageModel
    {
        private readonly PizzaPalacedbContext _context;

        public IndexModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IList<Orders> Orders { get;set; }
        public IList<OrderItem> OrderItem { get;set; }

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Store).ToListAsync();

            OrderItem = await _context.OrderItem.ToListAsync();
        }
    }
}

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

    public class IndexModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public IndexModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IList<PizzaOrder> PizzaOrder { get;set; }

        public async Task OnGetAsync()
        {
            PizzaOrder = await _context.PizzaOrder
                .Include(p => p.OrderItem)
                .Include(p => p.Pizza).ToListAsync();
        }
    }
}

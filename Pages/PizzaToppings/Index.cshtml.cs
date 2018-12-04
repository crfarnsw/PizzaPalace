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

    public class IndexModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public IndexModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IList<PizzaToppings> PizzaToppings { get;set; }

        public async Task OnGetAsync()
        {
            PizzaToppings = await _context.PizzaToppings
                .Include(p => p.PizzaOrder)
                .Include(p => p.Topping).ToListAsync();
        }
    }
}

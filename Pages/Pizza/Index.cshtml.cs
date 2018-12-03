

namespace PizzaPalace.Pages.Pizza
{
    using Pizza = PizzaPalace.Models.Pizza;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;
    using PizzaPalace.Models;

    public class IndexModel : PageModel
    {
        private readonly PizzaPalacedbContext _context;

        public IndexModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizza.ToListAsync();
        }
    }
}

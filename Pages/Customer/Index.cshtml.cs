using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public IndexModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IList<Models.Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}

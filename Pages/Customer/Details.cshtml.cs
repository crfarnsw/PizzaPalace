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
    using Customer = PizzaPalace.Models.Customer;

    public class DetailsModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public DetailsModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.CustomerId == id);

            if (Customer == null)
            {
                return NotFound();
            }
            
            return Page();
        }
    }
}

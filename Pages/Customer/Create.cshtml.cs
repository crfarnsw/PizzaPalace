
namespace PizzaPalace.Pages.Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using PizzaPalace.Models;
    using BCrypt.Net;
    using Customer = PizzaPalace.Models.Customer;

    public class CreateModel : PageModel
    {
        private readonly PizzaPalacedbContext _context;

        public CreateModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        /// <summary>
        /// Creates a new customer in the database. Hashes the password using Bcrypt.Net library.
        /// </summary>
        /// <returns>Returns the login page once the customer has registered.</returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var hashedPassword = BCrypt.HashPassword(Customer.Password);
            Customer.Password = hashedPassword;


            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Login");
        }
    }
}
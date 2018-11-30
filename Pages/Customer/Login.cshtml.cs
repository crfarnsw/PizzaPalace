namespace PizzaPalace.Pages.Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using PizzaPalace.Models;

    public class LoginModel : PageModel
    {
        private readonly PizzaPalacedbContext _context;

        public LoginModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public ActionResult OnPostWay2(string email, string password)
        {
            // to do : return something
            var customer = _context.Customer.FirstOrDefault(u => u.Email == email);
            
            if (customer == null)
            {
                return RedirectToPage("/Error");
            }

            return null;
        }

        public async Task<IActionResult> OnPostFirstAsync(string email, string password)
        {
            // to do : return something
            var customer = _context.Customer.FirstOrDefault(u => u.Email == email);

            if (customer == null)
            {
                return RedirectToPage("/Error");
            }


            return RedirectToPage("/Index");
        }
    }
}
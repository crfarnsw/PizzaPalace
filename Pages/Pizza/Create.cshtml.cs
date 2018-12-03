using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.Pizza
{
    using Pizza = PizzaPalace.Models.Pizza;

    public class CreateModel : PageModel
    {
        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public CreateModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pizza Pizza { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pizza.Add(Pizza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
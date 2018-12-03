using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaPalace.Pages.Shared.Components.Pizzas
{
    using PizzaPalace.Models;

    public class DefaultModel : PageModel
    {
        private PizzaPalacedbContext db = new PizzaPalacedbContext();
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            PizzaOrder pizzaOrder = new PizzaOrder();
            
            db.PizzaOrder.Add(pizzaOrder);
            db.SaveChanges();

            return Page();
        }

    }
}
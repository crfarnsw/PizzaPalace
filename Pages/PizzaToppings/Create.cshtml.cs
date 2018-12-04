using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.PizzaToppings
{
    using PizzaToppings = PizzaPalace.Models.PizzaToppings;

    public class CreateModel : PageModel
    {
        private readonly PizzaPalacedbContext _context;

        public int _OrderId { get; set; }
        public int _OrderItemId { get; set; }
        public int _PizzaOrderId { get; set; }

        string _redirectUrl { get; set; }

        public CreateModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int OrderId, int OrderItemId, int pizzaOrderId)
        {
            ViewData["OrderId"] = OrderId;
            ViewData["OrderItemId"] = OrderItemId;
            ViewData["PizzaOrderId"] = pizzaOrderId;

            _OrderId = OrderId;
            _OrderItemId = OrderItemId;
            _PizzaOrderId = pizzaOrderId;
            _redirectUrl = $"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}";

            ViewData["ToppingId"] = new SelectList(_context.Toppings, "ToppingId", "ToppingName");

            return Page();
        }

        [BindProperty]
        public PizzaToppings PizzaToppings { get; set; }

        public async Task<IActionResult> OnPostAsync(int OrderId, int OrderItemId, int pizzaOrderId)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            PizzaToppings.PizzaOrderId = pizzaOrderId;
            _context.PizzaToppings.Add(PizzaToppings);
            await _context.SaveChangesAsync();

            return Redirect($"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}");
        }
    }
}
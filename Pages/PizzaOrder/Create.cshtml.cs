using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaPalace.Models;

namespace PizzaPalace.Pages.PizzaOrder
{
    using PizzaOrder = Models.PizzaOrder;
    
    public class CreateModel : PageModel
    {
        public int _orderId;
        public int _orderItemId;
        public string _redirectUrl;

        private readonly PizzaPalacedbContext _context;

        public CreateModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int OrderId, int OrderItemId)
        {
            _orderId = OrderId;
            _orderItemId = OrderItemId;
            _redirectUrl = $"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}";

            ViewData["PizzaId"] = new SelectList(_context.Pizza, "PizzaId", "PizzaName");
            return Page();
        }

        [BindProperty]
        public PizzaOrder PizzaOrder { get; set; }

        public async Task<IActionResult> OnPostAsync(int OrderId, int OrderItemId)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PizzaOrder.Add(PizzaOrder);

            await _context.SaveChangesAsync();
            return Redirect($"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}");
        }
    }
}
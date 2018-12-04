namespace PizzaPalace.Pages.BeverageOrders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using PizzaPalace.Models;
    using PizzaPalace.Helpers;

    public class CreateModel : PageModel
    {
        private readonly PizzaPalacedbContext _context;
        public int _orderId;
        public int _orderItemId;
        public string _redirectUrl;

        public CreateModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int OrderId, int OrderItemId)
        {
            _orderId = OrderId;
            _orderItemId = OrderItemId;
            _redirectUrl = $"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}";

            ViewData["BeverageId"] = new SelectList(_context.Beverage, "BeverageId", "BeverageName");
            ViewData["OrderItemId"] = OrderItemId;
            return Page();
        }

        [BindProperty]
        public BeverageOrder BeverageOrder { get; set; }

        public async Task<IActionResult> OnPostAsync(int OrderId, int OrderItemId)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BeverageOrder.Add(BeverageOrder);
            await _context.SaveChangesAsync();

            return Redirect($"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}");
        }
    }
}
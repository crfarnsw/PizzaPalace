using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaPalace.Models;
using System.Threading.Tasks;

namespace PizzaPalace.Pages.SideOrders
{
    public class CreateModel : PageModel
    {
        public int _orderId;
        public int _orderItemId;
        public string _redirectUrl;

        private readonly PizzaPalace.Models.PizzaPalacedbContext _context;

        public CreateModel(PizzaPalace.Models.PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int OrderId, int OrderItemId)
        {
            _orderId = OrderId;
            _orderItemId = OrderItemId;
            _redirectUrl = $"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}";

            ViewData["SideId"] = new SelectList(_context.Side, "SideId", "SideName");
            return Page();
        }

        [BindProperty]
        public SideOrder SideOrder { get; set; }

        public async Task<IActionResult> OnPostAsync(int OrderId, int OrderItemId)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SideOrder.Add(SideOrder);
            await _context.SaveChangesAsync();

            return Redirect($"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}");
        }
    }
}
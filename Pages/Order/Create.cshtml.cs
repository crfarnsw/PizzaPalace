namespace PizzaPalace.Pages.Order
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.Mvc.Rendering;

    using PizzaPalace.Models;

    using System.Linq;
    using System.Threading.Tasks;

    public class CreateModel : PageModel
    {
        private readonly PizzaPalacedbContext _context;

        public CreateModel(PizzaPalacedbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CustomerId"] = _context.Customer.FirstOrDefault(u => u.Email == User.Identity.Name).CustomerId;
            ViewData["StoreId"] = new SelectList(_context.Store, "StoreId", "StoreAddress");
            return Page();
        }

        [BindProperty]
        public Orders Orders { get; set; }

        public OrderItem OrderItem = new OrderItem();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Orders.Add(Orders);

            _context.SaveChanges();

            int id = Orders.OrderId;
            OrderItem.OrderId = id;

            _context.OrderItem.Add(OrderItem);

            _context.SaveChanges();
            return Redirect($"/Order/Details?OrderId={Orders.OrderId}&OrderItemId={OrderItem.OrderItemId}");
        }
    }
}
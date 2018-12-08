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

        /// <summary>
        ///  Puts the customers customerid and all gets all stores into the ViewData[] so we can add this information to the order.
        /// </summary>
        /// <returns></returns>
        public IActionResult OnGet()
        {
            ViewData["CustomerId"] = _context.Customer.FirstOrDefault(u => u.Email == User.Identity.Name).CustomerId;
            ViewData["StoreId"] = new SelectList(_context.Store, "StoreId", "StoreAddress");
            return Page();
        }

        /// <summary>
        /// Set Orders as a bind property so we can retrieve the data from the inputs in the Create.cshtml page
        /// </summary>
        [BindProperty]
        public Orders Orders { get; set; }
        
        public OrderItem OrderItem = new OrderItem();

        /// <summary>
        /// Creates a new order and creates a new OrderItem 
        /// </summary>
        /// <returns>Redirects to the newly created order details</returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Add order to the database
            _context.Orders.Add(Orders);

            // Commit the transaction to the database
            _context.SaveChanges();

            // Set the newly created Order as the OrderItem's OrderId
            int id = Orders.OrderId;
            OrderItem.OrderId = id;

            // Add orderItem to the database
            _context.OrderItem.Add(OrderItem);

            _context.SaveChanges();
            return Redirect($"/Order/Details?OrderId={Orders.OrderId}&OrderItemId={OrderItem.OrderItemId}");
        }
    }
}
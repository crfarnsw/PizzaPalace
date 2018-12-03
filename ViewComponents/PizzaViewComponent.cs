using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PizzaPalace.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;

    using PizzaPalace.Models;

    [ViewComponent(Name = "Pizzas")]
    public class PizzaViewComponent : ViewComponent
    {
        private readonly PizzaPalacedbContext db;

        public PizzaViewComponent(PizzaPalacedbContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private Task<List<Pizza>> GetItemsAsync()
        {
            return db.Pizza.ToListAsync();
        }
    }
}

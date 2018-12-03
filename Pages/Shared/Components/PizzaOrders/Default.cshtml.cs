using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaPalace.Pages.Shared.Components.PizzaOrders
{
    using PizzaPalace.Models;

    public class DefaultModel : PageModel
    {
        private PizzaPalacedbContext _db = new PizzaPalacedbContext();

        [BindProperty]
        public InputData data { get; set; }

        public List<Pizza> pizzas = new List<Pizza>();

        public DefaultModel(PizzaPalacedbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            pizzas = _db.Pizza.ToList();
        }

        public class InputData
        {
            public string id { get; set; }
            public InputData()
            {}
        }
    }
}
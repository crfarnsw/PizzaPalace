using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPalace.Models;

namespace PizzaPalace.Controllers
{
    public class PizzaToppingsController : Controller
    {
        private readonly Models.PizzaPalacedbContext _context;

        // POST: PizzaToppings/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int OrderId, int OrderItemId, int PizzaToppingId)
        {
            try
            {
                PizzaToppings PizzaToppings = await _context.PizzaToppings.FindAsync(PizzaToppingId);

                if (PizzaToppings != null)
                {
                    _context.PizzaToppings.Remove(PizzaToppings);
                    await _context.SaveChangesAsync();
                }
                
            return Redirect($"/Order/Details?OrderId={OrderId}&OrderItemId={OrderItemId}");
            }
            catch
            {
                return View();
            }
        }

    }
}
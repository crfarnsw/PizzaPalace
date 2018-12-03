using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPalace.Models;
namespace PizzaPalace.Controllers
{
    public class PizzaOrderController : Controller
    {
        private PizzaPalacedbContext db = new PizzaPalacedbContext();

        // GET: PizzaOrder
        public ActionResult Index()
        {
            return View();
        }

        // GET: PizzaOrder/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PizzaOrder/Add
        public ActionResult Add(int pizzaId)
        {
            PizzaOrder pizzaOrder = new PizzaOrder();
            db.PizzaOrder.Add(pizzaOrder);
            db.SaveChanges();
            return ViewComponent("Pizzas");
        }

        // POST: PizzaOrder/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaOrder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaOrder/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaOrder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaOrder/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
﻿using la_mia_pizzeria_static.DB;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            using (PizzaContext db = new PizzaContext())
            {
                return View(db.Pizze.ToList());
            }
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            using (PizzaContext db = new PizzaContext())
            {
                Pizza pizza = db.Pizze.Find(id);
                return View(pizza);
            }
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

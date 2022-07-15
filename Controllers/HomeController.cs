using la_mia_pizzeria_static.DB;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using(PizzaContext db = new PizzaContext())
            {
                return View(db.Pizze.Take(4).ToList());
            }
        }

        [Route("menu")]
        public IActionResult Menu()
        {
            ViewData["Title"] = "Menu";

            using (PizzaContext db = new PizzaContext())
            {
                return View(db.Pizze.ToList());
            }
        }

        [Route("dove-siamo")]
        public IActionResult DoveSiamo()
        {
            ViewData["Title"] = "Dove Siamo";
            return View();
        }

        [Route("contatti")]
        public IActionResult Contatti()
        {
            ViewData["Title"] = "Contatti";
            return View();
        }

        [Route("prenota")]
        public IActionResult Prenota()
        {
            ViewData["Title"] = "Prenota";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
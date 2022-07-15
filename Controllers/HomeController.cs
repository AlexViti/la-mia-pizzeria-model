using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        readonly List<Pizza> pizzas = new()
            {
                new("Margherita", "Pomodoro, mozzarella, basilico", 9.99m, "img/margherita.png"),
                new("Prosciutto", "Pomodoro, mozzarella, prosciutto", 10.99m, "img/prosciutto.png"),
                new("Bufalina", "Pomodoro ciliegino, mozarella di bufala, olive", 11.99m, "img/bufalina.jpg"),
                new("Calzone", "Pomodoro, mozzarella, prosciutto", 12.99m, "https://www.pizzaventura.com/wp-content/uploads/2020/03/calzone.jpg")
            };
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(pizzas);
        }

        [Route("menu")]
        public IActionResult Menu()
        {
            ViewData["Title"] = "Menu";

            ViewData["Pizze"] = pizzas;
            return View();
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
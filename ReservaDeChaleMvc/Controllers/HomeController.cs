using Microsoft.AspNetCore.Mvc;
using ReservaDeChaleMvc.Data;
using ReservaDeChaleMvc.Models;
using System.Diagnostics;

namespace ReservaDeChaleMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ReservaDbContext _reserva;

        public HomeController(ILogger<HomeController> logger, ReservaDbContext reserva)
        {
            _logger = logger;
            _reserva = reserva;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Reservar()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       
    }
}

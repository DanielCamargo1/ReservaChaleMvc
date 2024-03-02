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

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Reservar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastros()
        {
            IEnumerable<ChaleModel> reservas = _reserva.Reserve;
            return View(reservas);
        }
    
        [HttpPost]
        public IActionResult Reservar(ChaleModel reserva)
        {
            if (ModelState.IsValid)
            {
                _reserva.Reserve.Add(reserva);
                _reserva.SaveChanges();
                return View("Index");
            }
            else 
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Login(ChaleModel login)
        {
            if (ModelState.IsValid)
            {
                if(login.Login == "hebreus" && login.Senha == 138) 
                {
                    return View("Cadastros");
                }
                else
                {
                    return View("Index");
                }
            }
            else
            {
                return BadRequest();
            }
        }







        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

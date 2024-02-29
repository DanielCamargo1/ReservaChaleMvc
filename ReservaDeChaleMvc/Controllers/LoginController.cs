using Microsoft.AspNetCore.Mvc;
using ReservaDeChaleMvc.Data;
using ReservaDeChaleMvc.Models;

namespace ReservaDeChaleMvc.Controllers
{
    public class LoginController : Controller
    {
        private readonly ReservaDbContext _login;

        public LoginController(ReservaDbContext login)
        {
            _login = login;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel log)
        {   
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            catch(Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}

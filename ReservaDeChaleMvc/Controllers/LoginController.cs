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

        [HttpGet]
        public IActionResult Cadastros()
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
                    if(log.Login == "hebreus" && log.Senha == 138)
                    {
                        return View("Cadastros");
                    }
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View("Index");
                }
            }
            catch(Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}

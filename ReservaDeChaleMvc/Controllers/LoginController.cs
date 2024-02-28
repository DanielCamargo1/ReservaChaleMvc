using Microsoft.AspNetCore.Mvc;
using ReservaDeChaleMvc.Models;

namespace ReservaDeChaleMvc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel login)
        {
            try
            {
                if (ModelState.IsValid)
                {
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

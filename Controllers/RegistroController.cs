using Microsoft.AspNetCore.Mvc;

namespace PM___Semana_6.Controllers
{
    public class RegistroController : Controller
    {
        public IActionResult Registrarse(){
            return View();
        }

        public IActionResult Recomendado(){
            return View();
        }
    }
}
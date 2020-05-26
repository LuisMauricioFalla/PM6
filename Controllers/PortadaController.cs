using Microsoft.AspNetCore.Mvc;

namespace PM___Semana_6.Controllers
{
    public class PortadaController : Controller
    {
        public IActionResult Default(){
            return View();
        }
        
        public IActionResult Descuento(){
            return View();
        }
        public IActionResult Nuevo(){
            return View();
        }
        public IActionResult Popular(){
            return View();
        }

    }
}
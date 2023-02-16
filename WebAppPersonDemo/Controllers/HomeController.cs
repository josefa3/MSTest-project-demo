using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppPersonDemo.Services;
using WebAppPersonDemo.Models;

namespace WebAppPersonDemo.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger; //comenta esto para que no le vaya a dar error, no se por que?

        private readonly IServicioPersona _servicioPersona; //agrega este atributo de tipo interfaz, para hacer la inyeccion de dependencia??

        public HomeController(IServicioPersona servicioPersona)
        {
            //_logger = logger;
            _servicioPersona = servicioPersona;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Crea este metodo
        public ViewResult CrearPersona(Persona persona)
        {
            if (_servicioPersona.EsValido(persona))
            {
                ViewBag.MensajeError = _servicioPersona.Errores[0];
                return View();
            }
            return View();
        }

        public IActionResult Privacy()
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
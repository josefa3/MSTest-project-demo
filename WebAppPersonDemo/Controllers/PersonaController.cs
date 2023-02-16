using Microsoft.AspNetCore.Mvc;
using WebAppPersonDemo.Services;
using WebAppPersonDemo.Models;

namespace WebAppPersonDemo.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

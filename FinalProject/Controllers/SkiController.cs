using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class SkiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Resorts()
        {
            return View();
        }

        public IActionResult Gear()
        {
            return View();
        }
    }
}

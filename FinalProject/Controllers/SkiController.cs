using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class SkiController : Controller
    {
        private SkiContext context;
        public SkiController(SkiContext ctx) => context = ctx;

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

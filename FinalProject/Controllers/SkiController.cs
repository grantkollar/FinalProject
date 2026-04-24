using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class SkiController : Controller
    {
        // inject the db context so we can pull resort data
        private SkiContext data;
        public SkiController(SkiContext ctx) => data = ctx;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Resorts()
        {
            // grab all resorts from the db and sort them alphabetically
            var resorts = data.Resorts.OrderBy(r => r.Name).ToList();
            return View(resorts);
        }

        public IActionResult Gear()
        {
            return View();
        }

        public IActionResult Tips()
        {
            return View();
        }
    }
}

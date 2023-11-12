using Microsoft.AspNetCore.Mvc;
using SnapSkill.Web.Models;
using System.Diagnostics;

namespace SnapSkill.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ICourse _course; 

        public HomeController(ILogger<HomeController> logger,ICourse course)
        {
            _logger = logger;
            _course = course;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("I am in index");
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
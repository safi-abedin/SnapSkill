using Microsoft.AspNetCore.Mvc;
using SnapSkill.Web.Areas.Admin.Models;

namespace SnapSkill.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        public IActionResult Courses()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            return View();
        }
    }
}

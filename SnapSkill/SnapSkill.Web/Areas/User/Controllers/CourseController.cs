using Microsoft.AspNetCore.Mvc;
using SnapSkill.Web.Areas.User.Models;
using SnapSkill.Web.Data;

namespace SnapSkill.Web.Areas.User.Controllers
{
    [Area("User")]
    public class CourseController : Controller
    {

        private readonly ApplicationDbContext _applicationDbContext;

        private ILogger<CourseController> _logger;

        private ICourse _course;

        public CourseController(ILogger<CourseController> logger, ICourse course, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _course = course;
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("I am Showing Data");

            var data = _applicationDbContext.Courses.ToList();

            foreach (var course in data)
            {
                course.SeparateTime();
            }
            return View(data);
        }
    }
}

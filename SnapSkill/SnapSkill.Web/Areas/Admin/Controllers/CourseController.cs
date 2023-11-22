using Microsoft.AspNetCore.Mvc;
using SnapSkill.Web.Areas.Admin.Models;
using SnapSkill.Web.Data;

namespace SnapSkill.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        private ILogger<CourseController> _logger;

        private ICourse _course; 

        public CourseController(ILogger<CourseController> logger,ICourse course,ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _course = course;
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Courses()
        {
            _logger.LogInformation("I am Showing Data");

            var data = _applicationDbContext.Courses.ToList();

            foreach(var course in data)
            {
                course.SeparateTime();
            }

            return View(data);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            var data = new Course
            {
                Name = course.Name,
                level = course.level,
                Description = course.Description,
                Price = course.Price,
                startDate = course.startDate,
                DayOfWeek = course.DayOfWeek,
                startTime = course.startTime,
                endTime = course.endTime,
                ImageURL = course.ImageURL
            };
            _applicationDbContext.Courses.Add(data);
             _applicationDbContext.SaveChanges();
            return View();
        }
    }
}

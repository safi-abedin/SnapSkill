﻿using Microsoft.AspNetCore.Mvc;

namespace SnapSkill.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

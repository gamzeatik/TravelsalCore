﻿using Microsoft.AspNetCore.Mvc;

namespace TravelsalCore.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

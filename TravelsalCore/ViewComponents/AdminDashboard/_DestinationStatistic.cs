﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TravelsalCore.ViewComponents.AdminDashboard
{
    public class _DestinationStatistic : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalCore.ViewComponents.MemberLayout
{
    public class _MemberLayoutSearch:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

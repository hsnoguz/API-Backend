using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    public class PerformanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

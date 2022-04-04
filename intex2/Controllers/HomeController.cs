﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using intex2.Models;

namespace intex2.Controllers
{
    public class HomeController : Controller
    {
 
    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Crashes()
        {
                
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult CalculatorResults()
        {
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

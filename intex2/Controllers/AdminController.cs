using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using intex2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace intex2.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private CrashesDbContext _context { get; set; }

        public AdminController(CrashesDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var crashes = _context.Crashes.ToList();
            return View(crashes);
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}

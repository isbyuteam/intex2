using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using intex2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using intex2.Models.ViewModels;

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

        public IActionResult Index(int pageNum = 1)
        {
            var crashes = _context.Crashes.ToList();
            int pageSize = 450;
            var pageData = new CrashViewModel
            {
                Crashes = _context.Crashes
                            .OrderBy(crash => crash.CRASH_ID)
                            .Skip((pageNum - 1) * pageSize)
                            .Take(pageSize),
                PageInfo = new PageInformation
                {
                    NumOfCrashes = _context.Crashes.Count(),
                    CrashesPerPage = pageSize,
                    CurrrentPage = pageNum
                }
            };

            return View(pageData);
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

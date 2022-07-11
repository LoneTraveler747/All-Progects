using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WarframeMarketCore.Models;

namespace WarframeMarketCore.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private AppDBContent db;

        public HomeController(AppDBContent content)
        {
            this.db = content;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PersonalAccount()
        {
            return View();
        }
        public async Task<ActionResult> Market()
        {
            return View(await db.Product.ToListAsync());
        }
        [HttpGet]
        public IActionResult Registration()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registr(Person person)
        {
            if (ModelState.IsValid)
            {
                return Content($"{person.login}");
            }
            else
            {
                return View(person);
            }
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult LostPassword()
        {
            return View();
        }
        public IActionResult OrderRegistation()
        {
            return View();
        }
    }
}

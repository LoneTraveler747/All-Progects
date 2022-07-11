using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warframe.Models;


namespace Warframe.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Warframe()
        {
            ClasssWarf p = new ClasssWarf()
            {
                Id = 1,
                Name = "",
                Prime = false
            };
            return View(p);
        }
        public ActionResult Soveti()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [MyActionFilter]
        public ActionResult CookFilter()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Keshirovanie.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            ViewBag.Message = "Операция была выполнена в " + DateTime.Now.ToLongTimeString();
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chto_to.Controllers
{
    public class ServerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Post()
        {
            ViewBag.Massage = Request.Form["massege"];
            return View("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warframe.Models
{
    public class MyActionFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.Cookies["test"] != null)
            {
                filterContext.Result = new HttpNotFoundResult();
            }
        }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {           
        }
    }
}
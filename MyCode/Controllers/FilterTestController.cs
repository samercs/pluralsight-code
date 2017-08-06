using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCode.Core.Filters;

namespace MyCode.Controllers
{
    [SessionFilter]
    public class FilterTestController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}
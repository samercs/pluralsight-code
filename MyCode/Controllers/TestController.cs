using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using MyCode.Core.Filters;
using MyCode.Data;

namespace MyCode.Controllers
{
    public class TestController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestCustomValueProvider(HeaderUserInfo headerUserInfo)
        {
            var context = new ApplicationContext();
            context.HeaderUserInfos.Add(headerUserInfo);
            context.SaveChanges();
            return View(headerUserInfo);
        }

        [HttpAuthntication("test", "test")]
        public JsonResult TestHttpAuthntication()
        {
            return Json("You are base the security check ...");
        }

        [MobileAppSelector]
        public ActionResult Mobile()
        {
            return View();
        }
    }
}
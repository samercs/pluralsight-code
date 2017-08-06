using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyCode.Core.Filters
{
    public class SessionFilter: FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = filterContext.HttpContext.Session["Tracker"];
            if (session == null)
            {
                filterContext.HttpContext.Session["Tracker"] = Guid.NewGuid();
                filterContext.Result = GenerateRedirectActionResult("Index", "Home");
            }
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
        }

        private System.Web.Mvc.ActionResult GenerateRedirectActionResult(string action, string controller)
        {
            return new RedirectToRouteResult(new RouteValueDictionary(new { action = action, controller = controller }) );
        }
    }
}
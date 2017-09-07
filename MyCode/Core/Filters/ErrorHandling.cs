
using System;
using System.Web.Mvc;
using Entity;
using MyCode.Data;

namespace MyCode.Core.Filters
{
    public class ErrorHandling: FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.HttpContext.Response.StatusCode = 500;
            filterContext.ExceptionHandled = true;

            var error = new ErrorLog
            {
                DateTime = DateTime.Now,
                Message = filterContext.Exception.Message,
                StackTrace = filterContext.Exception.StackTrace,
                ControllerName = filterContext.Controller.GetType().Name,
                UserAgint = filterContext.HttpContext.Request.UserAgent,
                TargetResult = filterContext.Result.GetType().Name
            };

            var context = new ApplicationContext();
            context.ErrorLogs.Add(error);
            context.SaveChanges();
        }
    }
}
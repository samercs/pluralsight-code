using System.Reflection;
using System.Web.Mvc;

namespace MyCode.Core.Filters
{
    public class MobileAppSelector: ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            var request = controllerContext.HttpContext.Request;
            return request.Headers["x-IsMobile"] != null;
        }
    }
}
using System.Web.Mvc;

namespace MyCode.Core.Infrastructer
{
    public class ThemViewEngine: RazorViewEngine
    {
        public ThemViewEngine(string themName)
        {
            ViewLocationFormats = new[]
            {
                "~/Views/Thems/"+themName+"/{1}/{0}.cshtml",
                "~/Views/Thems/"+themName+"/Shared/{0}.cshtml"
            };

            PartialViewLocationFormats = new[]
            {
                "~/Views/Thems/"+themName+"/{1}/{0}.cshtml",
                "~/Views/Thems/"+themName+"/Shared/{0}.cshtml"
            };
            AreaViewLocationFormats = new[]
            {
                "~/Areas/{2}/Views/Thems/"+themName+"/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/Thems/"+themName+"/Shared/{0}.cshtml"
            };
            AreaPartialViewLocationFormats = new[]
            {
                "~/Areas/{2}/Views/Thems/"+themName+"/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/Thems/"+themName+"/Shared/{0}.cshtml"
            };
        }
        
    }
}
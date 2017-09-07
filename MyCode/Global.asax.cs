﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyCode.Core.Filters;
using MyCode.Core.Infrastructer;

namespace MyCode
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ActiveThem"]))
            {
                ViewEngines.Engines.Insert(0, new ThemViewEngine(ConfigurationManager.AppSettings["ActiveThem"]));
            }

            AreaRegistration.RegisterAllAreas();
            GlobalFilters.Filters.Add(new SessionFilter());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

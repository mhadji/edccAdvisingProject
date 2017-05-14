﻿using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Mvc;

namespace edccAdvisingProject
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
           RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AreaRegistration.RegisterAllAreas();
           RouteConfig2.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig2.RegisterBundles(BundleTable.Bundles);
        }
    }
}
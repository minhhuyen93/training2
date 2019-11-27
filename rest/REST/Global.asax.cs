﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TinyERP.Common;
using TinyERP.Common.Common.Application;

namespace REST
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        IApplication app = ApplicationFactory.Create(ApplicationType.WebApi);
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            this.app.OnApplicationStarting();
        }

        protected void Application_End()
        {
            this.app.OnApplicationEnding();
        }
    }
}

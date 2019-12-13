﻿using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TinyERP.Common;
using TinyERP.Common.Common.Application;

namespace REST
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private IApplication app;
        public WebApiApplication()
        {
            this.app = ApplicationFactory.Create(ApplicationType.WebApi);
            this.Error += Application_Error;
        }
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
        private void Application_Error(object sender, EventArgs e)
        {
            this.app.OnApplicationErrors(((HttpApplication)sender).Context.AllErrors);
        }
    }
}

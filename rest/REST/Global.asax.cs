using REST.Common.Helper;
using REST.Common.IoC;
using REST.Common.Task;
using REST.Service;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace REST
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AssemblyHelper.Execute<IApplicationStarted>();
            AssemblyHelper.Execute<IBootStrapper>();
            AssemblyHelper.Execute<IApplicationReady>();
        }

        protected void Application_End()
        {
            AssemblyHelper.Execute<IApplicationEnd>();
        }
    }
}

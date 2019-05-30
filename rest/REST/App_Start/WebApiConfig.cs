using Newtonsoft.Json.Serialization;
using REST.Common.IoC;
using REST.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace REST
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            IoC.RegisterAsSingleton<IUserService, UserService>();
        }
    }
}

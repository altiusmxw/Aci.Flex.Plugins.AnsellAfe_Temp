using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Aci.Flex.Plugins.AnsellAfe.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
#if DEBUG
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

            json.SerializerSettings.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto;
            json.UseDataContractJsonSerializer = false;
#endif
            //config.Routes.MapHttpRoute(
            //    name: "Aci.Flex.Plugins.AnsellAfe.Web.Default",
            //    routeTemplate: "apiv2/{controller}/{action}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}

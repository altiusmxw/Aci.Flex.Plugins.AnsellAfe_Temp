using Aci.Flex.Interfaces;
using Aci.Flex.Portal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aci.Flex.Plugins.AnsellAfe.Web
{
    [ExportAsFlexPlugin(typeof(RouteConfig), typeof(IRouteConfig), false)]
    public class RouteConfig : IRouteConfig
    {
        public void RegisterRoutes(RouteCollection routes)
        {
#if DEBUG
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
#endif
        }

        public string Name
        {
            get { return "Aci.Flex.Plugins.AnsellAfe.Web.RouteConfig"; }
        }

        public int PluginType
        {
            get { return (int)Aci.Flex.Interfaces.PluginType.None; }
        }
    }
}

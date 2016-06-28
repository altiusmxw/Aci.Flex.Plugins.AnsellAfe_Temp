using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Aci.Flex.Plugins.AnsellAfe.Web
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);

#if DEBUG
            Portal.Platform.PlatformServices.RegisterPlatformService<AfePlatformServices>();
            RouteConfig routeConfig = new RouteConfig();
            routeConfig.RegisterRoutes(RouteTable.Routes);
#endif

            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
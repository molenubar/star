using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using AdaptiveUI.App_Start;

namespace AdaptiveUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DisplayModeConfig.RegisterDisplayModes(DisplayModeProvider.Instance.Modes);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("favicon.ico");
            routes.IgnoreRoute("{resource}.axd/{pathinfo}");


            //var routePublisher = EngineContenxt.Current.Resolve<IRoutePublisher>();
            //routePoublisher.RegisterRoutes(routes);

            routes.MapRoute(
                "Default", //Route name
                "{controller}/{action}/{id}", //parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "Acf.Web.Controllers" }
                );
        }
    }
}

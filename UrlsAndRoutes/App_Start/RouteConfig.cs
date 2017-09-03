using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });

            routes.MapRoute("MyRoute", "{controller}/{action}", new { controller ="Home", action = "Index" });

            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            //routes.Add("MyRoute", myRoute);
        }
    }
}

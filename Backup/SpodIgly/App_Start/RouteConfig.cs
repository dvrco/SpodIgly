using System.Web.Mvc;
using System.Web.Routing;

namespace SpodIgly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "ProductDetails",
                "album-{id}.html",
                new {controller = "Store", action = "Details"}
            );

            routes.MapRoute(
                "StaticPage",
                "strony/{viewname}.html",
                new {controller = "Home", action = "StaticContent"}
            );

            routes.MapRoute(
                "ProductList",
                "gatunki/{genrename}.html",
                new {controller = "Store", action = "List"},
                constraints: new{ genrename = @"[\w& ]+"}
            );

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );

        }
    }
}
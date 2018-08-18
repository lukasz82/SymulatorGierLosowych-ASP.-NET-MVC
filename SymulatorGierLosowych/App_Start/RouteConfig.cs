using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SymulatorGierLosowych
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Router dotyczący szczegółów gry
            routes.MapRoute(
                name: "GameDetalis",
                url: "game-{id}.html",
                defaults: new { controller = "Game", action = "Details" }
            );

            // Router do obsługi widoków
            routes.MapRoute(
                name: "StaticPages",
                url: "strony/{viewname}.html",
                defaults: new { controller = "Home", action = "StaticContent" }
            );

            // Router wczytujący listę gier
            routes.MapRoute(
                name: "GamesList",
                url: "gry/{gamename}",
                defaults: new { controller = "Game", action = "List" },
                // \w - tylko znaki alfanumeryczne, &-end i spacje(puste pole)
                constraints: new {gamename = @"[\w& ]+"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aprel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
  name: "Route1",
  url: "CoffeemachineDetails/{id}",
  defaults: new { action = "CoffeemachineDetails", controller = "Home", id = UrlParameter.Optional }
);





            routes.MapRoute(
                    name: "Default",
                    url: "{action}/{controller}/{id}",
                    defaults: new { action = "Index", controller = "Home", id = UrlParameter.Optional }
                );


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingPract
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "allstudents",
             url: "students",
             defaults: new { controller = "Students", action = "Getallstudents" }
                );

            routes.MapRoute(
     name: "studentdetails",
     url: "students/{id}",
     defaults: new { controller = "Students", action = "StudentDetails" },
     constraints: new
     {
         id = @"\d+"
     }
                );

            routes.MapRoute(
     name: "studentAddress",
     url: "students/{id}/address",
     defaults: new { controller = "Students", action = "StudentAddress" },
     constraints: new {id = @"\d+"}
 
        );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CaMauTravel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           
            routes.MapRoute(
                name: "Touris",
                url: "touris/{metatitle}-{placeID}",
                defaults: new { controller = "TourisUser", action = "PlaceTypeTouris", id = UrlParameter.Optional },
                namespaces: new[] {"CaMauTravel.Controllers"}
            );

            routes.MapRoute(
                name: "Touris Detail",
                url: "detail/{metatitle}-{id}",
                defaults: new { controller = "TourisUser", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );


            routes.MapRoute(
                name: "Touris Attraction",
                url: "attraction/{metatitle}-{attID}",
                defaults: new { controller = "Attendence", action = "PlaceTypeAttraction", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );

            routes.MapRoute(
                name: "Touris Attendence Detail",
                url: "detail/{metatitle}-{id}",
                defaults: new { controller = "Attendence", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );



            //routes.MapRoute(
            //    name: "Touris Attractions",
            //    url: "touris-attractions",
            //    defaults: new { controller = "TourisAttractions", action = "Index", id = UrlParameter.Optional },
            //    namespaces: new[] { "CaMauTravel.Controllers" }
            //);

            routes.MapRoute(
                name: "Touris Attractions Detail",
                url: "detail-touris-attractions/{metatitle}-{id}",
                defaults: new { controller = "TourisAttractions", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );

            routes.MapRoute(
                name: "Register",
                url: "register",
                defaults: new { controller = "Client", action = "Register", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );

            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "Client", action = "Login", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );

            routes.MapRoute(
                name: "Logout",
                url: "logout",
                defaults: new { controller = "Client", action = "Logout", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );


            routes.MapRoute(
                name: "Cart",
                url: "cart",
                defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );

            routes.MapRoute(
                name: "Add To Cart",
                url: "add-to-cart",
                defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );

            routes.MapRoute(
                name: "Payment",
                url: "payment",
                defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );

            routes.MapRoute(
                name: "Success",
                url: "success",
                defaults: new { controller = "Cart", action = "Success", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );

            routes.MapRoute(
                name: "About",
                url: "about",
                defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );

            routes.MapRoute(
                name: "Contact",
                url: "contact",
                defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "CaMauTravel.Controllers" }
            );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "MainHome", action = "Index", id = UrlParameter.Optional }
           );

        }
    }
}

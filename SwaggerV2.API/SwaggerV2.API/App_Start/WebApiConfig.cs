using SwaggerV2.API.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SwaggerV2.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Filters.Add(new BasicAuthenticationAttribute());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

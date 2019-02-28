// <copyright file="WebApiConfig.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace WebApiApplication
{
    using System;
    using System.Web.Http;
    using System.Web.Http.Cors;

    /// <summary>
    /// Filter Configuration
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Sets route config
        /// </summary>
        /// <param name = "config">HttpConfiguration type config parameter</param>
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы веб-API

            // Маршруты веб-API
            config.MapHttpAttributeRoutes();
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept", "text/html", StringComparison.InvariantCultureIgnoreCase, true, "application/json"));
        }
    }
}

// <copyright file="RouteConfig.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication
{
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// Routes Configuration
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Sets route config
        /// </summary>
        /// ///<param name = "routes">RouteCollection type routes parameter</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "EditForm", id = UrlParameter.Optional });
        }
    }
}

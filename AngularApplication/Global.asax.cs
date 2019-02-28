// <copyright file="Global.asax.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace AngularApplication
{
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// Start Configuration
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Start config
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}

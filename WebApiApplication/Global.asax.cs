// <copyright file="Global.asax.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace WebApiApplication
{
    using System;
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;   
    using System.Web.Routing;

    /// <summary>
    /// Start Configuration
    /// </summary>
    public class Global : HttpApplication
    {
        /// <summary>
        /// Start config
        /// </summary>
        /// <param name = "sender">object type sender parameter</param>
        /// <param name = "e">EventArgs type e parameter</param>
        public void Application_Start(object sender, EventArgs e)
        {
            // Код, выполняемый при запуске приложения
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }
    }
}
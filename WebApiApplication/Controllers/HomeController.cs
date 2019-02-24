// <copyright file="HomeController.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace WebApiApplication.Controllers
{
    using System;
    using System.Web.Mvc;

    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index Action Result
        /// </summary>
        /// <returns>The View Result</returns>
        public ActionResult Index()
        {
                return this.View();            
        }
    }
}

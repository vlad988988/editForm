// <copyright file="HomeController.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace AngularApplication.Controllers
{
    using System;
    using System.Web.Mvc;

    /// <summary>
    /// Basic controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// EditForm Action Result
        /// </summary>
        /// <returns>The View Result</returns>
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
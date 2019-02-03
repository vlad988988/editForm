// <copyright file="HomeController.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Controllers
{
    using System.Web.Mvc;
    using EditFormApplication.Models;

    /// <summary>
    /// Basic controller
    /// </summary>
    public class HomeController : Controller
    {
        [HttpGet]

        /// <summary>
        /// Returns View()
        /// </summary>
        /// <return> returns View</ return>
        public ActionResult EditForm()
        {
           return View();
        }

        [HttpPost]

        /// <summary>
        /// Gets model NewForm from view
        /// </summary>
        /// <return> returns Success</ return>
        public ActionResult EditForm(NewForm model)
        {
            Response.Write("Success");
            return View();
        }
    }
}
// <copyright file="HomeController.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Controllers
{
    using System;
    using System.Web.Mvc;
    using EditFormApplication.Models;

    /// <summary>
    /// Basic controller
    /// </summary>
    public class HomeController : Controller
    {
        [HttpGet]

        /// <summary>
        /// EditForm Action Result
        /// </summary>
        /// <returns>The View Result</returns>
        public ActionResult EditForm()
        {
           return this.View();
        }

        [HttpPost]

        /// <summary>
        /// EditForm Action Result
        /// </summary>
        /// <param name = "model">NewForm type model parameter</param>
        /// <returns>The View Result</returns>
        public ActionResult EditForm(NewForm model)
        {
            string id = Guid.NewGuid().ToString();
            if (model.Id != null)
            {
                this.ViewData["Message"] = model.HeadForm;
                return this.RedirectToAction("Message", new { model.HeadForm });
            }

            if (model.Id == null)
            {
                model.Id = id;

                this.Session["user"] = model;
            }

            return this.RedirectToAction("Edit", new { idForm = id });
        }

        /// <summary>
        /// Edit Action Result
        /// </summary>
        /// <param name = "idForm">String type Id parameter</param>
        /// <returns>The View Result</returns>
        public ActionResult Edit(string idForm)
        {  
            NewForm model = (NewForm)Session["user"];
            if (idForm == model.Id)
            {
                return this.View(model);
            }
            else
            {
                return this.HttpNotFound();
            }
        }

        /// <summary>
        /// Message Action Result
        /// </summary>
        /// <param name = "headForm">String type headForm parameter</param>
        /// <returns>The View Result</returns>
        public ActionResult Message(string headForm)
        {
            ViewBag.HeadForm = headForm;
            return this.View();
        }
    }
}
// <copyright file="HomeController.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Controllers
{
    using System;
    using System.Net;
    using System.Web.Mvc;
    using EditFormApplication.Models;

    /// <summary>
    /// Basic controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Repository Service
        /// </summary>
        private readonly IRepository<NewForm> db;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class
        /// </summary>
        public HomeController()
        {
            this.db = new SQLNewFormRepository();
        }

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
                if (ModelState.IsValid)
                {
                    this.db.Create(model);
                    this.db.Save();
                    return this.RedirectToAction("Edit", new { model.Id });
                }
                else
                {
                    return this.View(model);
                }                        
        }

        /// <summary>
        /// Edit Action Result
        /// </summary>
        /// <param name = "id">integer type id parameter</param>
        /// <returns>The View Result</returns>
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var model = this.db.GetNewForm((int)id);
                ViewBag.Num = model.Fields.Count;
                if (model == null)
                {
                    return this.HttpNotFound();
                }

            return this.View(model);
        }

        /// <summary>
        /// Edit Action Result
        /// </summary>
        /// <param name = "model">NewForm type model parameter</param>
        /// <returns>The View Result</returns>
        [HttpPost]
        public ActionResult Edit(NewForm model)
        {
            var form = this.db.GetNewForm(model.Id);
            form = model;                    
            this.db.Save();
            return this.RedirectToAction("Message", new { model.HeadForm }); 
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
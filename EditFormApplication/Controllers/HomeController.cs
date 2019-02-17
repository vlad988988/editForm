// <copyright file="HomeController.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
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
            using (NewFormContext db = new NewFormContext())
            {
                if (ModelState.IsValid)
                {
                    db.NewForms.Add(model);
                    db.SaveChanges();
                    return this.RedirectToAction("Edit", new { model.Id });
                }
                else
                {
                    return this.View(model);
                }             
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

            using (NewFormContext db = new NewFormContext())
            {
                var model = db.NewForms.Find(id);
                ViewBag.Num = model.Fields.Count;
                if (model == null)
                {
                    return this.HttpNotFound();
                }

                return this.View(model);
            }
        }

        /// <summary>
        /// Edit Action Result
        /// </summary>
        /// <param name = "model">NewForm type model parameter</param>
        /// <returns>The View Result</returns>
        [HttpPost]
        public ActionResult Edit(NewForm model)
        {
            using (NewFormContext db = new NewFormContext())
            {
                var form = db.NewForms.Find(model.Id);
                form.HeadForm = model.HeadForm;
                form.DescriptionForm = model.DescriptionForm;
                form.Fields = model.Fields;
                db.SaveChanges();
                return this.RedirectToAction("Message", new { model.HeadForm }); 
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
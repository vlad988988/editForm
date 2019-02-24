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
        IRepository<NewForm> db;

        public HomeController()
        {
            db = new SQLNewFormRepository();
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
                    db.Create(model);
                    db.Save();
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

            var model = db.GetNewForm((int)id);
                ViewBag.Num = model.Fields.Count;
                if (model == null)
                {
                    return this.HttpNotFound();
                }
            //for (int i = 0; i < model.Fields.Count; i++)
            //{
            //    Response.Write(model.Fields[i].SelectedOne);
            //    Response.Write(model.Fields[i].SelectedTwo);
            //}
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
            var form = db.GetNewForm(model.Id);
            form = model;                    
            db.Save();
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
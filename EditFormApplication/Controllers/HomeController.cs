// <copyright file="HomeController.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
            //using (NewFormContext db = new NewFormContext()) {
                //var form = db.NewForms.Find(1);
                //form.HeadField = model.HeadField;
                //form.HeadForm = model.HeadForm;
                //form.DescriptionForm = model.DescriptionForm;
                foreach(var e in model.Fields)
            {
                Response.Write(e.HeadField);
            }
               
                //db.SaveChanges();

                
                //return RedirectToAction("Edit");
                return View();
            //}        
            
        }

        /// <summary>
        /// Edit Action Result
        /// </summary>
        /// <param name = "idForm">String type Id parameter</param>
        /// <returns>The View Result</returns>
        public ActionResult Edit()
        {
            using (NewFormContext db = new NewFormContext()) { 
                var model = db.NewForms.Find(1);
                
            return this.View(model);
        }
        }

        [HttpPost]
        public ActionResult Edit(NewForm model)
        {
            using (NewFormContext db = new NewFormContext())
            {
               
                return this.View(model);
            }
        }
        /// <summary>
        /// Message Action Result
        /// </summary>
        /// <param name = "headForm">String type headForm parameter</param>
        /// <returns>The View Result</returns>
        //public ActionResult Message(string headForm)
        //{
        //    ViewBag.HeadForm = headForm;
        //    return this.View();
        //}
    }
}
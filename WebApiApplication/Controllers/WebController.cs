// <copyright file="WebController.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace WebApiApplication.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;
    using WebApiApplication.Models;

    /// <summary>
    /// Web Controller
    /// </summary>
    public class WebController : ApiController
    {
        /// <summary>
        /// New object of EditFormConnect
        /// </summary>
        private readonly EditFormConnect sql = new EditFormConnect();

        [HttpGet]

        /// <summary>
        /// Get name by index
        /// </summary>
        /// <param name = "id">integer type id parameter</param>
        /// <returns>Filled form</returns>
        public NewForm GetNamesByIndex(int id)
        {
            NewForm newForm = new NewForm();
            newForm = this.sql.GetNewFormData(id, newForm);
            List<Field> fields = new List<Field>();
            fields = this.sql.GetFieldData(id, fields);
            newForm.Fields = fields;
            return newForm;           
        }
    }
}

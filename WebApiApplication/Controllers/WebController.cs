// <copyright file="WebController.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace WebApiApplication.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;
    using WebApiApplication.Models;

    public class WebController : ApiController
    {
        EditFormConnect sql = new EditFormConnect();

        [HttpGet]
        public NewForm GetNamesByIndex(int id)
        {
            NewForm newForm = new NewForm();
            newForm = sql.getNewFormData(id, newForm);
            List<Field> fields = new List<Field>();
            fields = sql.getFieldData(id, fields);
            newForm.Fields = fields;
            return newForm;           
        }
    }
}



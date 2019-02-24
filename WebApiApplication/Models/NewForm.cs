using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiApplication.Models
{
    public class NewForm
    {
        public string HeadForm { get; set; }

        public string DescriptionForm { get; set; }

        public List<Field> Fields { get; set; }
    }
    public class Field
    {
        public bool Check { get; set; }
        public string HeadField { get; set; }
        public string TypeFields { get; set; }
        public string SelectedOne { get; set; }
        public string SelectedTwo { get; set; }
    }
}
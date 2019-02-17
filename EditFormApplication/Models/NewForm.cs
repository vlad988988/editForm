// <copyright file="NewForm.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    /// <summary>
    /// Model for view
    /// </summary>
    public class NewForm
    {
        /// <summary>
        /// Gets or sets field with name="HeadForm" 
        /// </summary>
         [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets field with name="HeadForm" 
        /// </summary>
        public string HeadForm { get; set; }

        /// <summary>
        /// Gets or sets field with name="DescriptionForm" 
        /// </summary>
        public string DescriptionForm { get; set; }

        /// <summary>
        /// Gets or sets field with name="HeadField" 
        /// </summary>
        //public HeadField HeadFields { get; set; }
        public virtual ICollection <Field> Fields { get; set; }

        /// <summary>
        /// Gets or sets field with name="TypeField" 
        /// </summary>
        //public string TypeFields { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether field with name="Check"
        /// </summary>

        //public bool Check { get; set; }

        /// <summary>
        /// Gets or sets field with name="Selected" 
        /// </summary>
        //public string SelectedOne { get; set; }

        /// <summary>
        /// Gets or sets field with name="Selected" 
        /// </summary>
        //public string SelectedTwo { get; set; }

        
    }

    public class Field
    {
        public int Id { get; set; }
        public string HeadField { get; set; }
        public int NewFormId { get; set; }

        public virtual NewForm NewForm { get; set; }
    }
    //public class Check
    //{
    //    public string MyCheck { get; set; }
    //}

    //public class Block
    //{
    //    public int id { get; set; }
    //    public string HeadField { get; set; }
    //}
}

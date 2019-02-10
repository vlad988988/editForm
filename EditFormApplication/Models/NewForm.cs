// <copyright file="NewForm.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    /// <summary>
    /// Model for view
    /// </summary>
    public class NewForm
    {
        /// <summary>
        /// Gets or sets field with name="HeadForm" 
        /// </summary>
        public string Id { get; set; }

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
        public List<string> HeadFields { get; set; }

        /// <summary>
        /// Gets or sets field with name="TypeField" 
        /// </summary>
        public List<SelectListItem> TypeFields { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether field with name="Check"
        /// </summary>
        public List<bool> Check { get; set; }

        /// <summary>
        /// Gets or sets field with name="Selected" 
        /// </summary>
        public List<string> SelectedOne { get; set; }

        /// <summary>
        /// Gets or sets field with name="Selected" 
        /// </summary>
        public List<string> SelectedTwo { get; set; }
    }
}

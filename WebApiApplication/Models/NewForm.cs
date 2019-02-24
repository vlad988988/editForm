// <copyright file="NewForm.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace WebApiApplication.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Model for NewForm table
    /// </summary>
    public class NewForm
    {
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
        public List<Field> Fields { get; set; }
    }
}
// <copyright file="NewForm.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model for view
    /// </summary>
    public class NewForm
    {
        /// <summary>
        /// Gets or sets Id 
        /// </summary>
        public int Id { get; set; }

        [Required]

        /// <summary>
        /// Gets or sets field with name="HeadForm" 
        /// </summary>
        public string HeadForm { get; set; }

        [Required]

        /// <summary>
        /// Gets or sets field with name="DescriptionForm" 
        /// </summary>
        public string DescriptionForm { get; set; }

        /// <summary>
        /// Gets or sets field with name="HeadField" 
        /// </summary>
        public virtual List<Field> Fields { get; set; }
    }
}

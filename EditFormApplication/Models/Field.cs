// <copyright file="Field.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model of list of fields
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Gets or sets Id 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether field with name="Check"
        /// </summary>
        public bool Check { get; set; }

        [Required]

        /// <summary>
        /// Gets or sets field with name="HeadField" 
        /// </summary>
        public string HeadField { get; set; }

        /// <summary>
        /// Gets or sets field with name="Selected" 
        /// </summary>
        public string Selected { get; set; }

        /// <summary>
        /// Gets or sets NewFormId 
        /// </summary>
        public int? NewFormId { get; set; }

        /// <summary>
        /// Gets or sets NewForm object for one to many 
        /// </summary>
        public virtual NewForm NewForm { get; set; }
    }
}
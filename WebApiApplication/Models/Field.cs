// <copyright file="Field.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace WebApiApplication.Models
{
    using System;

    /// <summary>
    /// Model of list of fields
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Gets or sets a value indicating whether field with name="Check"
        /// </summary>
        public bool Check { get; set; }

        /// <summary>
        /// Gets or sets field with name="HeadField" 
        /// </summary>
        public string HeadField { get; set; }

        /// <summary>
        /// Gets or sets field with name="TypeField" 
        /// </summary>
        public string TypeFields { get; set; }

        /// <summary>
        /// Gets or sets field with name="Selected" 
        /// </summary>
        public string SelectedOne { get; set; }

        /// <summary>
        /// Gets or sets field with name="Selected" 
        /// </summary>
        public string SelectedTwo { get; set; }
    }
}
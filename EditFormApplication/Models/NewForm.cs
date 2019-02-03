// <copyright file="NewForm.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Models
{
    /// <summary>
    /// Model for view
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
        public string[] HeadField { get; set; }

        /// <summary>
        /// Gets or sets field with name="TypeField" 
        /// </summary>
        public string[] TypeField { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether field with name="Check"
        /// </summary>
        public bool Check { get; set; }

        /// <summary>
        /// Gets or sets field with name="Selected" 
        /// </summary>
        public string[] Selected { get; set; }
    }
}
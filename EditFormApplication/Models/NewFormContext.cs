// <copyright file="NewFormContext.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Class of context
    /// </summary>
    public class NewFormContext : DbContext
    {
        /// <summary>
        /// Gets or sets NewForms for DB 
        /// </summary>
        public DbSet<NewForm> NewForms { get; set; }

        /// <summary>
        /// Gets or sets Fields for DB 
        /// </summary>
        public DbSet<Field> Fields { get; set; }
    }

}
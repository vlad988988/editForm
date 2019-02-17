// <copyright file="Configuration.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    /// <summary>
    ///  sealed class migration
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<EditFormApplication.Models.NewFormContext>
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.ContextKey = "EditFormApplication.Models.NewFormContext";
        }

        /// <summary>
        /// Seed method for start data
        /// </summary>
        /// /// <param name = "context">EditFormApplication.Models.NewFormContext type context parameter</param>
        protected override void Seed(EditFormApplication.Models.NewFormContext context)
        {
        }
    }
}

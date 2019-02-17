// <copyright file="201902171702489_MigrateDB.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Class migration
    /// </summary>
    public partial class MigrateDB : DbMigration
    {
        /// <summary>
        /// Up method for data
        /// </summary>
        public override void Up()
        {
            this.AddColumn("dbo.Fields", "TypeFields", c => c.String());
            this.AddColumn("dbo.Fields", "SelectedOne", c => c.String());
            this.AddColumn("dbo.Fields", "SelectedTwo", c => c.String());
            this.AddColumn("dbo.NewForms", "DescriptionForm", c => c.String());
        }

        /// <summary>
        /// Down method for data
        /// </summary>
        public override void Down()
        {
            this.DropColumn("dbo.NewForms", "DescriptionForm");
            this.DropColumn("dbo.Fields", "SelectedTwo");
            this.DropColumn("dbo.Fields", "SelectedOne");
            this.DropColumn("dbo.Fields", "TypeFields");
        }
    }
}

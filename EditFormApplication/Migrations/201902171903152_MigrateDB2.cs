// <copyright file="201902171903152_MigrateDB2.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Class migration
    /// </summary>
    public partial class MigrateDB2 : DbMigration
    {
        /// <summary>
        /// Up method for data
        /// </summary>
        public override void Up()
        {
            this.AlterColumn("dbo.Fields", "HeadField", c => c.String(nullable: false));
            this.AlterColumn("dbo.NewForms", "HeadForm", c => c.String(nullable: false));
            this.AlterColumn("dbo.NewForms", "DescriptionForm", c => c.String(nullable: false));
        }

        /// <summary>
        /// Down method for data
        /// </summary>
        public override void Down()
        {
            this.AlterColumn("dbo.NewForms", "DescriptionForm", c => c.String());
            this.AlterColumn("dbo.NewForms", "HeadForm", c => c.String());
            this.AlterColumn("dbo.Fields", "HeadField", c => c.String());
        }
    }
}

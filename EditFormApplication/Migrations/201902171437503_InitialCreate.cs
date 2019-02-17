// <copyright file="201902171437503_InitialCreate.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Class migration
    /// </summary>
    public partial class InitialCreate : DbMigration
    {
        /// <summary>
        /// Up method for data
        /// </summary>
        public override void Up()
        {
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Check = c.Boolean(nullable: false),
                        HeadField = c.String(),
                        NewFormId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewForms", t => t.NewFormId)
                .Index(t => t.NewFormId);
            
            CreateTable(
                "dbo.NewForms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HeadForm = c.String(),
                    })
                .PrimaryKey(t => t.Id);
        }

        /// <summary>
        /// Down method for data
        /// </summary>
        public override void Down()
        {
            this.DropForeignKey("dbo.Fields", "NewFormId", "dbo.NewForms");
            this.DropIndex("dbo.Fields", new[] { "NewFormId" });
            this.DropTable("dbo.NewForms");
            this.DropTable("dbo.Fields");
        }
    }
}

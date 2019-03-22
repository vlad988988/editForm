namespace EditFormApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Check = c.Boolean(nullable: false),
                        HeadField = c.String(nullable: false),
                        Selected = c.String(),
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
                        HeadForm = c.String(nullable: false),
                        DescriptionForm = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fields", "NewFormId", "dbo.NewForms");
            DropIndex("dbo.Fields", new[] { "NewFormId" });
            DropTable("dbo.NewForms");
            DropTable("dbo.Fields");
        }
    }
}

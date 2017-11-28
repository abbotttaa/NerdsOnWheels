namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyForServices : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Service_ID", c => c.Int());
            AddColumn("dbo.Technicians", "Service_ID", c => c.Int());
            CreateIndex("dbo.Customers", "Service_ID");
            CreateIndex("dbo.Technicians", "Service_ID");
            AddForeignKey("dbo.Customers", "Service_ID", "dbo.Services", "ID");
            AddForeignKey("dbo.Technicians", "Service_ID", "dbo.Services", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Technicians", "Service_ID", "dbo.Services");
            DropForeignKey("dbo.Customers", "Service_ID", "dbo.Services");
            DropIndex("dbo.Technicians", new[] { "Service_ID" });
            DropIndex("dbo.Customers", new[] { "Service_ID" });
            DropColumn("dbo.Technicians", "Service_ID");
            DropColumn("dbo.Customers", "Service_ID");
        }
    }
}

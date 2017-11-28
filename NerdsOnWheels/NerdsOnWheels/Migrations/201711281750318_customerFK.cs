namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customerFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Service_ID", "dbo.Services");
            DropForeignKey("dbo.Technicians", "Service_ID", "dbo.Services");
            DropIndex("dbo.Customers", new[] { "Service_ID" });
            DropIndex("dbo.Technicians", new[] { "Service_ID" });
            AddColumn("dbo.Services", "CustomerId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Services", "CustomerId");
            AddForeignKey("dbo.Services", "CustomerId", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Customers", "Service_ID");
            DropColumn("dbo.Technicians", "Service_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Technicians", "Service_ID", c => c.Int());
            AddColumn("dbo.Customers", "Service_ID", c => c.Int());
            DropForeignKey("dbo.Services", "CustomerId", "dbo.AspNetUsers");
            DropIndex("dbo.Services", new[] { "CustomerId" });
            DropColumn("dbo.Services", "CustomerId");
            CreateIndex("dbo.Technicians", "Service_ID");
            CreateIndex("dbo.Customers", "Service_ID");
            AddForeignKey("dbo.Technicians", "Service_ID", "dbo.Services", "ID");
            AddForeignKey("dbo.Customers", "Service_ID", "dbo.Services", "ID");
        }
    }
}

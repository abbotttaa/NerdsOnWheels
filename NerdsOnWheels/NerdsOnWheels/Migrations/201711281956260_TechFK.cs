namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TechFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "TechnicianId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Services", "TechnicianId");
            AddForeignKey("dbo.Services", "TechnicianId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "TechnicianId", "dbo.AspNetUsers");
            DropIndex("dbo.Services", new[] { "TechnicianId" });
            DropColumn("dbo.Services", "TechnicianId");
        }
    }
}

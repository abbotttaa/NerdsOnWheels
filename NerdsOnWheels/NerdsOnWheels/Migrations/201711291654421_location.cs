namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class location : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Technicians", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Technicians", "Location");
        }
    }
}

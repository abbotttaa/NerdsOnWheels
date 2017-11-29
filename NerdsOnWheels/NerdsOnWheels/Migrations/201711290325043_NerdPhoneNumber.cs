namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NerdPhoneNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Technicians", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Technicians", "PhoneNumber");
        }
    }
}

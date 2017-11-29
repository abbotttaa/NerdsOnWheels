namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class confirmPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Technicians", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Technicians", "ConfirmPassword");
        }
    }
}

namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nerdEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Technicians", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Technicians", "Email");
        }
    }
}

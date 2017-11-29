namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class instructor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Technicians", "Password", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Technicians", "Password", c => c.String(nullable: false));
        }
    }
}

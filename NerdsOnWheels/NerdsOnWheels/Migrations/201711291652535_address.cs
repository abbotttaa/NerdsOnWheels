namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Address");
        }
    }
}

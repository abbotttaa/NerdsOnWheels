namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "CustomerTypeOfIssue");
            DropColumn("dbo.Customers", "CustomerDescriptionOfIssue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerDescriptionOfIssue", c => c.String());
            AddColumn("dbo.Customers", "CustomerTypeOfIssue", c => c.String());
        }
    }
}

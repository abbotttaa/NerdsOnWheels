namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerIssues : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerTypeOfIssue", c => c.String());
            AddColumn("dbo.Customers", "CustomerDescriptionOfIssue", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerDescriptionOfIssue");
            DropColumn("dbo.Customers", "CustomerTypeOfIssue");
        }
    }
}

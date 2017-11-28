namespace NerdsOnWheels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssistanceRequestDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "AssistanceRequestDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "AssistanceRequestDescription");
        }
    }
}

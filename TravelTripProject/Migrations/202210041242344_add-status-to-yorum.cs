namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstatustoyorum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yorumlars", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yorumlars", "Status");
        }
    }
}

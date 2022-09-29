namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlikestatustoblog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "LikeStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "LikeStatus");
        }
    }
}

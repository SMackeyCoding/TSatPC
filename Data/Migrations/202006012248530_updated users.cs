namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedusers : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "UserId");
            DropColumn("dbo.AspNetUsers", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.AspNetUsers", "UserId", c => c.Guid(nullable: false));
        }
    }
}

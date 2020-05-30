namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OmittedCommentProblems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        CreatedAtUtc = c.DateTime(nullable: false),
                        CharacterId = c.Int(nullable: false),
                        PlanetId = c.Int(nullable: false),
                        ShipId = c.Int(nullable: false),
                        WeaponId = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.Characters", t => t.CharacterId, cascadeDelete: true)
                .ForeignKey("dbo.Planets", t => t.PlanetId, cascadeDelete: true)
                .ForeignKey("dbo.Ships", t => t.ShipId, cascadeDelete: true)
                .ForeignKey("dbo.Weapons", t => t.WeaponId, cascadeDelete: true)
                .Index(t => t.CharacterId)
                .Index(t => t.PlanetId)
                .Index(t => t.ShipId)
                .Index(t => t.WeaponId)
                .Index(t => t.ApplicationUser_Id);
            
            DropColumn("dbo.AspNetRoles", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetRoles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Comments", "WeaponId", "dbo.Weapons");
            DropForeignKey("dbo.Comments", "ShipId", "dbo.Ships");
            DropForeignKey("dbo.Comments", "PlanetId", "dbo.Planets");
            DropForeignKey("dbo.Comments", "CharacterId", "dbo.Characters");
            DropForeignKey("dbo.Comments", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Comments", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Comments", new[] { "WeaponId" });
            DropIndex("dbo.Comments", new[] { "ShipId" });
            DropIndex("dbo.Comments", new[] { "PlanetId" });
            DropIndex("dbo.Comments", new[] { "CharacterId" });
            DropTable("dbo.Comments");
        }
    }
}

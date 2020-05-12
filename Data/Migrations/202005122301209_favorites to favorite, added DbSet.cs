namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class favoritestofavoriteaddedDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        FavoritesId = c.Int(nullable: false, identity: true),
                        CharacterId = c.Int(nullable: false),
                        PlanetId = c.Int(nullable: false),
                        ShipId = c.Int(nullable: false),
                        WeaponId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FavoritesId)
                .ForeignKey("dbo.Characters", t => t.CharacterId, cascadeDelete: true)
                .ForeignKey("dbo.Planets", t => t.PlanetId, cascadeDelete: true)
                .ForeignKey("dbo.Ships", t => t.ShipId, cascadeDelete: true)
                .ForeignKey("dbo.Weapons", t => t.WeaponId, cascadeDelete: true)
                .Index(t => t.CharacterId)
                .Index(t => t.PlanetId)
                .Index(t => t.ShipId)
                .Index(t => t.WeaponId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Favorites", "WeaponId", "dbo.Weapons");
            DropForeignKey("dbo.Favorites", "ShipId", "dbo.Ships");
            DropForeignKey("dbo.Favorites", "PlanetId", "dbo.Planets");
            DropForeignKey("dbo.Favorites", "CharacterId", "dbo.Characters");
            DropIndex("dbo.Favorites", new[] { "WeaponId" });
            DropIndex("dbo.Favorites", new[] { "ShipId" });
            DropIndex("dbo.Favorites", new[] { "PlanetId" });
            DropIndex("dbo.Favorites", new[] { "CharacterId" });
            DropTable("dbo.Favorites");
        }
    }
}

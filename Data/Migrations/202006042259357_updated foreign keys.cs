namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedforeignkeys : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Characters", "DefaultWeaponId", c => c.Int());
            AlterColumn("dbo.Characters", "DefaultShipId", c => c.Int());
            CreateIndex("dbo.Characters", "DefaultWeaponId");
            CreateIndex("dbo.Characters", "DefaultShipId");
            AddForeignKey("dbo.Characters", "DefaultShipId", "dbo.Ships", "ShipId");
            AddForeignKey("dbo.Characters", "DefaultWeaponId", "dbo.Weapons", "WeaponId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "DefaultWeaponId", "dbo.Weapons");
            DropForeignKey("dbo.Characters", "DefaultShipId", "dbo.Ships");
            DropIndex("dbo.Characters", new[] { "DefaultShipId" });
            DropIndex("dbo.Characters", new[] { "DefaultWeaponId" });
            AlterColumn("dbo.Characters", "DefaultShipId", c => c.Int(nullable: false));
            AlterColumn("dbo.Characters", "DefaultWeaponId", c => c.Int(nullable: false));
        }
    }
}

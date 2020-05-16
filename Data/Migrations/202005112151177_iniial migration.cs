namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iniialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(),
                        Species = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Affiliation = c.String(),
                        DefaultWeaponId = c.Int(nullable: false),
                        DefaultShipId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CharacterId);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        ContractId = c.Int(nullable: false, identity: true),
                        ContractDescription = c.String(),
                        CharacterId = c.Int(nullable: false),
                        PlanetId = c.Int(nullable: false),
                        ShipId = c.Int(nullable: false),
                        WeaponId = c.Int(nullable: false),
                        ContractPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContractId)
                .ForeignKey("dbo.Characters", t => t.CharacterId, cascadeDelete: true)
                .ForeignKey("dbo.Planets", t => t.PlanetId, cascadeDelete: true)
                .ForeignKey("dbo.Ships", t => t.ShipId, cascadeDelete: true)
                .ForeignKey("dbo.Weapons", t => t.WeaponId, cascadeDelete: true)
                .Index(t => t.CharacterId)
                .Index(t => t.PlanetId)
                .Index(t => t.ShipId)
                .Index(t => t.WeaponId);
            
            CreateTable(
                "dbo.Planets",
                c => new
                    {
                        PlanetId = c.Int(nullable: false, identity: true),
                        PlanetName = c.String(),
                        PlanetDescription = c.String(),
                        PlanetClimate = c.String(),
                        HoursPerDay = c.Int(nullable: false),
                        DaysPerYear = c.Int(nullable: false),
                        NumberOfSuns = c.Int(nullable: false),
                        NumberOfMoons = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlanetId);
            
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        ShipId = c.Int(nullable: false, identity: true),
                        ShipName = c.String(nullable: false),
                        ShipClass = c.String(nullable: false),
                        ShipModel = c.String(nullable: false),
                        ShipManufacturer = c.String(nullable: false),
                        ShipHyperdrive = c.Boolean(nullable: false),
                        ShipLength = c.Int(nullable: false),
                        ShipMaxSpeed = c.Int(nullable: false),
                        ShipPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShipId);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        WeaponId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Type = c.Int(nullable: false),
                        Range = c.String(nullable: false),
                        WeaponColor = c.String(nullable: false),
                        BladeOrEnergyColor = c.String(),
                        Damage = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WeaponId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Contracts", "WeaponId", "dbo.Weapons");
            DropForeignKey("dbo.Contracts", "ShipId", "dbo.Ships");
            DropForeignKey("dbo.Contracts", "PlanetId", "dbo.Planets");
            DropForeignKey("dbo.Contracts", "CharacterId", "dbo.Characters");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Contracts", new[] { "WeaponId" });
            DropIndex("dbo.Contracts", new[] { "ShipId" });
            DropIndex("dbo.Contracts", new[] { "PlanetId" });
            DropIndex("dbo.Contracts", new[] { "CharacterId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Weapons");
            DropTable("dbo.Ships");
            DropTable("dbo.Planets");
            DropTable("dbo.Contracts");
            DropTable("dbo.Characters");
        }
    }
}

namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedShipClasstoenumtypeaddedContractStatusenumtype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ships", "ShipClass", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ships", "ShipClass", c => c.String(nullable: false));
        }
    }
}

namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contractstatusadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contracts", "ContractStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contracts", "ContractStatus");
        }
    }
}

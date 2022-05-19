namespace CoCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringinv : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Devices", "InventoryNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Devices", "InventoryNumber", c => c.Int(nullable: false));
        }
    }
}

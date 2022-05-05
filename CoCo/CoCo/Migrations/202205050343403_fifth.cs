namespace CoCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Repairs", "DeviceId", "dbo.Devices");
            DropIndex("dbo.Repairs", new[] { "DeviceId" });
            RenameColumn(table: "dbo.Repairs", name: "DeviceId", newName: "Device_Id");
            AlterColumn("dbo.Repairs", "Device_Id", c => c.Int(identity: true));
            CreateIndex("dbo.Repairs", "Device_Id");
            AddForeignKey("dbo.Repairs", "Device_Id", "dbo.Devices", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repairs", "Device_Id", "dbo.Devices");
            DropIndex("dbo.Repairs", new[] { "Device_Id" });
            AlterColumn("dbo.Repairs", "Device_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Repairs", name: "Device_Id", newName: "DeviceId");
            CreateIndex("dbo.Repairs", "DeviceId");
            AddForeignKey("dbo.Repairs", "DeviceId", "dbo.Devices", "Id", cascadeDelete: true);
        }
    }
}

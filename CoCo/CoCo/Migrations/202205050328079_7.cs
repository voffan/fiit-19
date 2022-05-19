namespace CoCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Repairs", "Device_Id", "dbo.Devices");
            DropIndex("dbo.Repairs", new[] { "Device_Id" });
            RenameColumn(table: "dbo.Repairs", name: "Device_Id", newName: "DeviceId");
            AlterColumn("dbo.Repairs", "DeviceId", c => c.Int(nullable: false));
            CreateIndex("dbo.Repairs", "DeviceId");
            AddForeignKey("dbo.Repairs", "DeviceId", "dbo.Devices", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repairs", "DeviceId", "dbo.Devices");
            DropIndex("dbo.Repairs", new[] { "DeviceId" });
            AlterColumn("dbo.Repairs", "DeviceId", c => c.Int());
            RenameColumn(table: "dbo.Repairs", name: "DeviceId", newName: "Device_Id");
            CreateIndex("dbo.Repairs", "Device_Id");
            AddForeignKey("dbo.Repairs", "Device_Id", "dbo.Devices", "Id");
        }
    }
}

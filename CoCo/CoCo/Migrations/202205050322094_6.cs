namespace CoCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Repairs", "Id", "dbo.Devices");
            DropIndex("dbo.Repairs", new[] { "Id" });
            DropPrimaryKey("dbo.Repairs");
            AddColumn("dbo.Repairs", "Device_Id", c => c.Int());
            AlterColumn("dbo.Repairs", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Repairs", "Id");
            CreateIndex("dbo.Repairs", "Device_Id");
            AddForeignKey("dbo.Repairs", "Device_Id", "dbo.Devices", "Id");
            DropColumn("dbo.Repairs", "DeviceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Repairs", "DeviceId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Repairs", "Device_Id", "dbo.Devices");
            DropIndex("dbo.Repairs", new[] { "Device_Id" });
            DropPrimaryKey("dbo.Repairs");
            AlterColumn("dbo.Repairs", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.Repairs", "Device_Id");
            AddPrimaryKey("dbo.Repairs", "DeviceId");
            CreateIndex("dbo.Repairs", "Id");
            AddForeignKey("dbo.Repairs", "Id", "dbo.Devices", "Id", cascadeDelete: true);
        }
    }
}

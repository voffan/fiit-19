namespace CoCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Repairs", "Device_Id", "dbo.Devices");
            DropIndex("dbo.Repairs", new[] { "Device_Id" });
            RenameColumn(table: "dbo.Repairs", name: "Device_Id", newName: "Id");
            AlterColumn("dbo.Repairs", "Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Repairs", "Id");
            AddForeignKey("dbo.Repairs", "Id", "dbo.Devices", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repairs", "Id", "dbo.Devices");
            DropIndex("dbo.Repairs", new[] { "Id" });
            AlterColumn("dbo.Repairs", "Id", c => c.Int());
            RenameColumn(table: "dbo.Repairs", name: "Id", newName: "Device_Id");
            CreateIndex("dbo.Repairs", "Device_Id");
            AddForeignKey("dbo.Repairs", "Device_Id", "dbo.Devices", "Id");
        }
    }
}

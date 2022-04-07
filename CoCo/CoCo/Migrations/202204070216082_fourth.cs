namespace CoCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Devices", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Devices", "EmployeeId");
            AddForeignKey("dbo.Devices", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Devices", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Devices", new[] { "EmployeeId" });
            DropColumn("dbo.Devices", "EmployeeId");
        }
    }
}

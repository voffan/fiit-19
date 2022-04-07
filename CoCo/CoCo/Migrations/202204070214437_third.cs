namespace CoCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Devices", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Devices", "EmployeeId1", "dbo.Employees");
            DropIndex("dbo.Devices", new[] { "EmployeeId" });
            DropIndex("dbo.Devices", new[] { "EmployeeId1" });
            DropColumn("dbo.Devices", "EmployeeId");
            DropColumn("dbo.Devices", "EmployeeId1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Devices", "EmployeeId1", c => c.Int());
            AddColumn("dbo.Devices", "EmployeeId", c => c.Int());
            CreateIndex("dbo.Devices", "EmployeeId1");
            CreateIndex("dbo.Devices", "EmployeeId");
            AddForeignKey("dbo.Devices", "EmployeeId1", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Devices", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}

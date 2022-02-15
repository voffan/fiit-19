namespace CoCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cpus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 300),
                        Frequency = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Manufacturer = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InventoryNumber = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        HddId = c.Int(),
                        CpuId = c.Int(),
                        MotherboardId = c.Int(),
                        EmployeeId = c.Int(),
                        Name = c.String(maxLength: 300),
                        Manufacturer = c.String(maxLength: 300),
                        EmployeeId1 = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cpus", t => t.CpuId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Hdds", t => t.HddId, cascadeDelete: true)
                .ForeignKey("dbo.Motherboards", t => t.MotherboardId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId1, cascadeDelete: false)
                .Index(t => t.HddId)
                .Index(t => t.CpuId)
                .Index(t => t.MotherboardId)
                .Index(t => t.EmployeeId)
                .Index(t => t.EmployeeId1);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 300),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Hdds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 300),
                        Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Manufacturer = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Motherboards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 300),
                        Manufacturer = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        DeviceId = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        BegginingDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        Cause = c.String(maxLength: 300),
                        Device_Id = c.Int(),
                    })
                .PrimaryKey(t => t.DeviceId)
                .ForeignKey("dbo.Devices", t => t.Device_Id)
                .Index(t => t.Device_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repairs", "Device_Id", "dbo.Devices");
            DropForeignKey("dbo.Devices", "EmployeeId1", "dbo.Employees");
            DropForeignKey("dbo.Devices", "MotherboardId", "dbo.Motherboards");
            DropForeignKey("dbo.Devices", "HddId", "dbo.Hdds");
            DropForeignKey("dbo.Devices", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Devices", "CpuId", "dbo.Cpus");
            DropIndex("dbo.Repairs", new[] { "Device_Id" });
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Devices", new[] { "EmployeeId1" });
            DropIndex("dbo.Devices", new[] { "EmployeeId" });
            DropIndex("dbo.Devices", new[] { "MotherboardId" });
            DropIndex("dbo.Devices", new[] { "CpuId" });
            DropIndex("dbo.Devices", new[] { "HddId" });
            DropTable("dbo.Repairs");
            DropTable("dbo.Motherboards");
            DropTable("dbo.Hdds");
            DropTable("dbo.Employees");
            DropTable("dbo.Devices");
            DropTable("dbo.Departments");
            DropTable("dbo.Cpus");
        }
    }
}

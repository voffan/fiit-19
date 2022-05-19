namespace CoCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 300),
                        DepartmentId = c.Int(nullable: false),
                        Password = c.String(maxLength: 300),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.Devices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InventoryNumber = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        HddId = c.Int(),
                        CpuId = c.Int(),
                        MotherboardId = c.Int(),
                        Name = c.String(maxLength: 300),
                        Manufacturer = c.String(maxLength: 300),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Cpus", t => t.CpuId, cascadeDelete: true)
                .ForeignKey("dbo.Hdds", t => t.HddId, cascadeDelete: true)
                .ForeignKey("dbo.Motherboards", t => t.MotherboardId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.HddId)
                .Index(t => t.CpuId)
                .Index(t => t.MotherboardId);
            
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
                        Id = c.Int(nullable: false, identity: true),
                        DeviceId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        BegginingDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        Cause = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Devices", t => t.DeviceId, cascadeDelete: true)
                .Index(t => t.DeviceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repairs", "DeviceId", "dbo.Devices");
            DropForeignKey("dbo.Devices", "MotherboardId", "dbo.Motherboards");
            DropForeignKey("dbo.Devices", "HddId", "dbo.Hdds");
            DropForeignKey("dbo.Devices", "CpuId", "dbo.Cpus");
            DropForeignKey("dbo.Devices", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Repairs", new[] { "DeviceId" });
            DropIndex("dbo.Devices", new[] { "MotherboardId" });
            DropIndex("dbo.Devices", new[] { "CpuId" });
            DropIndex("dbo.Devices", new[] { "HddId" });
            DropIndex("dbo.Devices", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropTable("dbo.Repairs");
            DropTable("dbo.Motherboards");
            DropTable("dbo.Hdds");
            DropTable("dbo.Devices");
            DropTable("dbo.Cpus");
            DropTable("dbo.Departments");
            DropTable("dbo.Employees");
        }
    }
}

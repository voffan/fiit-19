namespace SMMeM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INIT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        Birthday = c.DateTime(nullable: false),
                        Position = c.Int(nullable: false),
                        EmployerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employers", t => t.EmployerId, cascadeDelete: true)
                .Index(t => t.EmployerId);
            
            CreateTable(
                "dbo.Employers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Code = c.String(maxLength: 255),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.ErrorComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(maxLength: 500),
                        ErrorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Errors", t => t.ErrorId, cascadeDelete: true)
                .Index(t => t.ErrorId);
            
            CreateTable(
                "dbo.Solutions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Code = c.String(maxLength: 255),
                        ErrorId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.Errors", t => t.ErrorId, cascadeDelete: true)
                .Index(t => t.ErrorId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.SolutionComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(maxLength: 500),
                        SolutionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Solutions", t => t.SolutionId, cascadeDelete: true)
                .Index(t => t.SolutionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Solutions", "ErrorId", "dbo.Errors");
            DropForeignKey("dbo.Solutions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.SolutionComments", "SolutionId", "dbo.Solutions");
            DropForeignKey("dbo.Errors", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.ErrorComments", "ErrorId", "dbo.Errors");
            DropForeignKey("dbo.Employees", "EmployerId", "dbo.Employers");
            DropIndex("dbo.SolutionComments", new[] { "SolutionId" });
            DropIndex("dbo.Solutions", new[] { "EmployeeId" });
            DropIndex("dbo.Solutions", new[] { "ErrorId" });
            DropIndex("dbo.ErrorComments", new[] { "ErrorId" });
            DropIndex("dbo.Errors", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "EmployerId" });
            DropTable("dbo.SolutionComments");
            DropTable("dbo.Solutions");
            DropTable("dbo.ErrorComments");
            DropTable("dbo.Errors");
            DropTable("dbo.Employers");
            DropTable("dbo.Employees");
        }
    }
}

namespace SportAchievements.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        DateBeginning = c.DateTime(nullable: false),
                        DateEnding = c.DateTime(nullable: false),
                        CompTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CompTypes", t => t.CompTypeId, cascadeDelete: true)
                .Index(t => t.CompTypeId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        Position = c.String(maxLength: 50),
                        Login = c.String(maxLength: 50),
                        Pwd = c.String(maxLength: 50),
                        Gender = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Weight_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WeightCategories", t => t.Weight_Id)
                .Index(t => t.Weight_Id);
            
            CreateTable(
                "dbo.CompTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KindOfSports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeightCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        SportKind_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KindOfSports", t => t.SportKind_Id)
                .Index(t => t.SportKind_Id);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Place = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                        SportsmanId = c.Int(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                        KindOfSportId = c.Int(nullable: false),
                        WeightCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.KindOfSports", t => t.KindOfSportId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.SportsmanId, cascadeDelete: true)
                .ForeignKey("dbo.WeightCategories", t => t.WeightCategoryId, cascadeDelete: true)
                .Index(t => t.SportsmanId)
                .Index(t => t.CompetitionId)
                .Index(t => t.KindOfSportId)
                .Index(t => t.WeightCategoryId);
            
            CreateTable(
                "dbo.EmployeeCompetitions",
                c => new
                    {
                        Employee_Id = c.Int(nullable: false),
                        Competition_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_Id, t.Competition_Id })
                .ForeignKey("dbo.People", t => t.Employee_Id, cascadeDelete: true)
                .ForeignKey("dbo.Competitions", t => t.Competition_Id, cascadeDelete: true)
                .Index(t => t.Employee_Id)
                .Index(t => t.Competition_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "WeightCategoryId", "dbo.WeightCategories");
            DropForeignKey("dbo.Results", "SportsmanId", "dbo.People");
            DropForeignKey("dbo.Results", "KindOfSportId", "dbo.KindOfSports");
            DropForeignKey("dbo.Results", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.People", "Weight_Id", "dbo.WeightCategories");
            DropForeignKey("dbo.WeightCategories", "SportKind_Id", "dbo.KindOfSports");
            DropForeignKey("dbo.Competitions", "CompTypeId", "dbo.CompTypes");
            DropForeignKey("dbo.EmployeeCompetitions", "Competition_Id", "dbo.Competitions");
            DropForeignKey("dbo.EmployeeCompetitions", "Employee_Id", "dbo.People");
            DropIndex("dbo.EmployeeCompetitions", new[] { "Competition_Id" });
            DropIndex("dbo.EmployeeCompetitions", new[] { "Employee_Id" });
            DropIndex("dbo.Results", new[] { "WeightCategoryId" });
            DropIndex("dbo.Results", new[] { "KindOfSportId" });
            DropIndex("dbo.Results", new[] { "CompetitionId" });
            DropIndex("dbo.Results", new[] { "SportsmanId" });
            DropIndex("dbo.WeightCategories", new[] { "SportKind_Id" });
            DropIndex("dbo.People", new[] { "Weight_Id" });
            DropIndex("dbo.Competitions", new[] { "CompTypeId" });
            DropTable("dbo.EmployeeCompetitions");
            DropTable("dbo.Results");
            DropTable("dbo.WeightCategories");
            DropTable("dbo.KindOfSports");
            DropTable("dbo.CompTypes");
            DropTable("dbo.People");
            DropTable("dbo.Competitions");
        }
    }
}

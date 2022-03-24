namespace SportAchievements.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KindOfSportCompetitions",
                c => new
                    {
                        KindOfSport_Id = c.Int(nullable: false),
                        Competition_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.KindOfSport_Id, t.Competition_Id })
                .ForeignKey("dbo.KindOfSports", t => t.KindOfSport_Id, cascadeDelete: true)
                .ForeignKey("dbo.Competitions", t => t.Competition_Id, cascadeDelete: true)
                .Index(t => t.KindOfSport_Id)
                .Index(t => t.Competition_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KindOfSportCompetitions", "Competition_Id", "dbo.Competitions");
            DropForeignKey("dbo.KindOfSportCompetitions", "KindOfSport_Id", "dbo.KindOfSports");
            DropIndex("dbo.KindOfSportCompetitions", new[] { "Competition_Id" });
            DropIndex("dbo.KindOfSportCompetitions", new[] { "KindOfSport_Id" });
            DropTable("dbo.KindOfSportCompetitions");
        }
    }
}

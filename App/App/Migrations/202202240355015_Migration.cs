namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Humen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Address = c.String(maxLength: 100),
                        Passport = c.String(maxLength: 11),
                        Birthday = c.DateTime(),
                        PhoneNumber = c.String(maxLength: 15),
                        BlackList = c.Boolean(),
                        Position = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Film_Id = c.Int(),
                        Film_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Films", t => t.Film_Id)
                .ForeignKey("dbo.Films", t => t.Film_Id1)
                .Index(t => t.Film_Id)
                .Index(t => t.Film_Id1);
            
            CreateTable(
                "dbo.Disks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Year = c.Int(nullable: false),
                        AgeCategory = c.Int(nullable: false),
                        FilmMaker_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Humen", t => t.FilmMaker_Id)
                .Index(t => t.FilmMaker_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pledge = c.Int(nullable: false),
                        PledgeDescription = c.String(maxLength: 100),
                        Client_Id = c.Int(),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Humen", t => t.Client_Id)
                .ForeignKey("dbo.Humen", t => t.Employee_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.FilmDisks",
                c => new
                    {
                        Film_Id = c.Int(nullable: false),
                        Disk_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Film_Id, t.Disk_Id })
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .ForeignKey("dbo.Disks", t => t.Disk_Id, cascadeDelete: true)
                .Index(t => t.Film_Id)
                .Index(t => t.Disk_Id);
            
            CreateTable(
                "dbo.GenreFilms",
                c => new
                    {
                        Genre_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Film_Id })
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Film_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Employee_Id", "dbo.Humen");
            DropForeignKey("dbo.Orders", "Client_Id", "dbo.Humen");
            DropForeignKey("dbo.Humen", "Film_Id1", "dbo.Films");
            DropForeignKey("dbo.GenreFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.GenreFilms", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.FilmDisks", "Disk_Id", "dbo.Disks");
            DropForeignKey("dbo.FilmDisks", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.Humen", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.Films", "FilmMaker_Id", "dbo.Humen");
            DropIndex("dbo.GenreFilms", new[] { "Film_Id" });
            DropIndex("dbo.GenreFilms", new[] { "Genre_Id" });
            DropIndex("dbo.FilmDisks", new[] { "Disk_Id" });
            DropIndex("dbo.FilmDisks", new[] { "Film_Id" });
            DropIndex("dbo.Orders", new[] { "Employee_Id" });
            DropIndex("dbo.Orders", new[] { "Client_Id" });
            DropIndex("dbo.Films", new[] { "FilmMaker_Id" });
            DropIndex("dbo.Humen", new[] { "Film_Id1" });
            DropIndex("dbo.Humen", new[] { "Film_Id" });
            DropTable("dbo.GenreFilms");
            DropTable("dbo.FilmDisks");
            DropTable("dbo.Orders");
            DropTable("dbo.Genres");
            DropTable("dbo.Films");
            DropTable("dbo.Disks");
            DropTable("dbo.Humen");
        }
    }
}

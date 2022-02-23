namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Disks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Address = c.String(maxLength: 100),
                        Passport = c.String(),
                        Birth = c.DateTime(nullable: false),
                        BlackList = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Address = c.String(maxLength: 100),
                        Passport = c.String(),
                        Birth = c.DateTime(nullable: false),
                        Position = c.Int(nullable: false),
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
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.FilmActors",
                c => new
                    {
                        Film_Id = c.Int(nullable: false),
                        Actor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Film_Id, t.Actor_Id })
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.Actor_Id, cascadeDelete: true)
                .Index(t => t.Film_Id)
                .Index(t => t.Actor_Id);
            
            CreateTable(
                "dbo.DiskFilms",
                c => new
                    {
                        Disk_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Disk_Id, t.Film_Id })
                .ForeignKey("dbo.Disks", t => t.Disk_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.Disk_Id)
                .Index(t => t.Film_Id);
            
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
            
            CreateTable(
                "dbo.ProducerFilms",
                c => new
                    {
                        Producer_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Producer_Id, t.Film_Id })
                .ForeignKey("dbo.Producers", t => t.Producer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.Producer_Id)
                .Index(t => t.Film_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Orders", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.ProducerFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.ProducerFilms", "Producer_Id", "dbo.Producers");
            DropForeignKey("dbo.GenreFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.GenreFilms", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.DiskFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.DiskFilms", "Disk_Id", "dbo.Disks");
            DropForeignKey("dbo.FilmActors", "Actor_Id", "dbo.Actors");
            DropForeignKey("dbo.FilmActors", "Film_Id", "dbo.Films");
            DropIndex("dbo.ProducerFilms", new[] { "Film_Id" });
            DropIndex("dbo.ProducerFilms", new[] { "Producer_Id" });
            DropIndex("dbo.GenreFilms", new[] { "Film_Id" });
            DropIndex("dbo.GenreFilms", new[] { "Genre_Id" });
            DropIndex("dbo.DiskFilms", new[] { "Film_Id" });
            DropIndex("dbo.DiskFilms", new[] { "Disk_Id" });
            DropIndex("dbo.FilmActors", new[] { "Actor_Id" });
            DropIndex("dbo.FilmActors", new[] { "Film_Id" });
            DropIndex("dbo.Orders", new[] { "Employee_Id" });
            DropIndex("dbo.Orders", new[] { "Client_Id" });
            DropTable("dbo.ProducerFilms");
            DropTable("dbo.GenreFilms");
            DropTable("dbo.DiskFilms");
            DropTable("dbo.FilmActors");
            DropTable("dbo.Orders");
            DropTable("dbo.Employees");
            DropTable("dbo.Clients");
            DropTable("dbo.Producers");
            DropTable("dbo.Genres");
            DropTable("dbo.Disks");
            DropTable("dbo.Films");
            DropTable("dbo.Actors");
        }
    }
}

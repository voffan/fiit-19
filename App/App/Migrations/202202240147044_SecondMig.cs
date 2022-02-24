namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMig : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FilmActors", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.FilmActors", "Actor_Id", "dbo.Actors");
            DropForeignKey("dbo.DiskFilms", "Disk_Id", "dbo.Disks");
            DropForeignKey("dbo.DiskFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.ProducerFilms", "Producer_Id", "dbo.Producers");
            DropForeignKey("dbo.ProducerFilms", "Film_Id", "dbo.Films");
            DropIndex("dbo.FilmActors", new[] { "Film_Id" });
            DropIndex("dbo.FilmActors", new[] { "Actor_Id" });
            DropIndex("dbo.DiskFilms", new[] { "Disk_Id" });
            DropIndex("dbo.DiskFilms", new[] { "Film_Id" });
            DropIndex("dbo.ProducerFilms", new[] { "Producer_Id" });
            DropIndex("dbo.ProducerFilms", new[] { "Film_Id" });
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Film_Id = c.Int(),
                        Film_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Films", t => t.Film_Id)
                .ForeignKey("dbo.Films", t => t.Film_Id1)
                .Index(t => t.Film_Id)
                .Index(t => t.Film_Id1);
            
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
            
            AddColumn("dbo.Films", "Person_Id", c => c.Int());
            AddColumn("dbo.Clients", "Birthday", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "Birthday", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clients", "Passport", c => c.String(maxLength: 11));
            AlterColumn("dbo.Employees", "Passport", c => c.String(maxLength: 11));
            CreateIndex("dbo.Films", "Person_Id");
            AddForeignKey("dbo.Films", "Person_Id", "dbo.People", "Id");
            DropColumn("dbo.Clients", "Birth");
            DropColumn("dbo.Employees", "Birth");
            DropTable("dbo.Actors");
            DropTable("dbo.Producers");
            DropTable("dbo.FilmActors");
            DropTable("dbo.DiskFilms");
            DropTable("dbo.ProducerFilms");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProducerFilms",
                c => new
                    {
                        Producer_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Producer_Id, t.Film_Id });
            
            CreateTable(
                "dbo.DiskFilms",
                c => new
                    {
                        Disk_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Disk_Id, t.Film_Id });
            
            CreateTable(
                "dbo.FilmActors",
                c => new
                    {
                        Film_Id = c.Int(nullable: false),
                        Actor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Film_Id, t.Actor_Id });
            
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "Birth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "Birth", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.People", "Film_Id1", "dbo.Films");
            DropForeignKey("dbo.FilmDisks", "Disk_Id", "dbo.Disks");
            DropForeignKey("dbo.FilmDisks", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.People", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.Films", "Person_Id", "dbo.People");
            DropIndex("dbo.FilmDisks", new[] { "Disk_Id" });
            DropIndex("dbo.FilmDisks", new[] { "Film_Id" });
            DropIndex("dbo.People", new[] { "Film_Id1" });
            DropIndex("dbo.People", new[] { "Film_Id" });
            DropIndex("dbo.Films", new[] { "Person_Id" });
            AlterColumn("dbo.Employees", "Passport", c => c.String());
            AlterColumn("dbo.Clients", "Passport", c => c.String());
            DropColumn("dbo.Employees", "Birthday");
            DropColumn("dbo.Clients", "Birthday");
            DropColumn("dbo.Films", "Person_Id");
            DropTable("dbo.FilmDisks");
            DropTable("dbo.People");
            CreateIndex("dbo.ProducerFilms", "Film_Id");
            CreateIndex("dbo.ProducerFilms", "Producer_Id");
            CreateIndex("dbo.DiskFilms", "Film_Id");
            CreateIndex("dbo.DiskFilms", "Disk_Id");
            CreateIndex("dbo.FilmActors", "Actor_Id");
            CreateIndex("dbo.FilmActors", "Film_Id");
            AddForeignKey("dbo.ProducerFilms", "Film_Id", "dbo.Films", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProducerFilms", "Producer_Id", "dbo.Producers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DiskFilms", "Film_Id", "dbo.Films", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DiskFilms", "Disk_Id", "dbo.Disks", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FilmActors", "Actor_Id", "dbo.Actors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FilmActors", "Film_Id", "dbo.Films", "Id", cascadeDelete: true);
        }
    }
}

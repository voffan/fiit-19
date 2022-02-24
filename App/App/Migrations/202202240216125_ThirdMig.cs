namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMig : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clients", newName: "People");
            RenameTable(name: "dbo.FilmDisks", newName: "DiskFilms");
            DropPrimaryKey("dbo.DiskFilms");
            AddColumn("dbo.People", "Position", c => c.Int());
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.People", "Film_Id", c => c.Int());
            AddColumn("dbo.People", "Film_Id1", c => c.Int());
            AlterColumn("dbo.People", "Birthday", c => c.DateTime());
            AlterColumn("dbo.People", "BlackList", c => c.Boolean());
            AddPrimaryKey("dbo.DiskFilms", new[] { "Disk_Id", "Film_Id" });
            DropTable("dbo.People");
            DropTable("dbo.Employees");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Address = c.String(maxLength: 100),
                        Passport = c.String(maxLength: 11),
                        Birthday = c.DateTime(nullable: false),
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Film_Id = c.Int(),
                        Film_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropPrimaryKey("dbo.DiskFilms");
            AlterColumn("dbo.People", "BlackList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.People", "Birthday", c => c.DateTime(nullable: false));
            DropColumn("dbo.People", "Film_Id1");
            DropColumn("dbo.People", "Film_Id");
            DropColumn("dbo.People", "Discriminator");
            DropColumn("dbo.People", "Position");
            AddPrimaryKey("dbo.DiskFilms", new[] { "Film_Id", "Disk_Id" });
            RenameTable(name: "dbo.DiskFilms", newName: "FilmDisks");
            RenameTable(name: "dbo.People", newName: "Clients");
        }
    }
}

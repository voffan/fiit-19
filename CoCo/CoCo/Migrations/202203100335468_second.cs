namespace CoCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Password", c => c.String(maxLength: 300));
            AddColumn("dbo.Employees", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Discriminator");
            DropColumn("dbo.Employees", "Password");
        }
    }
}

namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empl_Login : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Humen", "Login", c => c.String(maxLength: 20));
            AddColumn("dbo.Humen", "Password", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Humen", "Password");
            DropColumn("dbo.Humen", "Login");
        }
    }
}

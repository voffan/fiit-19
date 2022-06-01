namespace CoCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class login : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Login", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Login");
        }
    }
}

namespace SportAchievements.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourthmigration : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.People", name: "Weight_Id", newName: "WeightCategoryId");
            RenameIndex(table: "dbo.People", name: "IX_Weight_Id", newName: "IX_WeightCategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.People", name: "IX_WeightCategoryId", newName: "IX_Weight_Id");
            RenameColumn(table: "dbo.People", name: "WeightCategoryId", newName: "Weight_Id");
        }
    }
}

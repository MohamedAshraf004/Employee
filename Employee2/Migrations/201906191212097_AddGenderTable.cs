namespace Employee2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Gender_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "Gender_Id");
            AddForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Employees", new[] { "Gender_Id" });
            DropColumn("dbo.Employees", "Gender_Id");
        }
    }
}

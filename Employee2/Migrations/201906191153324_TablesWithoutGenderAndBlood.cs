namespace Employee2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesWithoutGenderAndBlood : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "BloodGroup_Id", "dbo.BloodGroups");
            DropForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Employees", new[] { "BloodGroup_Id" });
            DropIndex("dbo.Employees", new[] { "Gender_Id" });
            DropColumn("dbo.Employees", "BloodGroup_Id");
            DropColumn("dbo.Employees", "Gender_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Gender_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "BloodGroup_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "Gender_Id");
            CreateIndex("dbo.Employees", "BloodGroup_Id");
            AddForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "BloodGroup_Id", "dbo.BloodGroups", "Id", cascadeDelete: true);
        }
    }
}

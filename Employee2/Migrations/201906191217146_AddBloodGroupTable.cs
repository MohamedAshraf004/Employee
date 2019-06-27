namespace Employee2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBloodGroupTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "BloodGroup_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "BloodGroup_Id");
            AddForeignKey("dbo.Employees", "BloodGroup_Id", "dbo.BloodGroups", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "BloodGroup_Id", "dbo.BloodGroups");
            DropIndex("dbo.Employees", new[] { "BloodGroup_Id" });
            DropColumn("dbo.Employees", "BloodGroup_Id");
        }
    }
}

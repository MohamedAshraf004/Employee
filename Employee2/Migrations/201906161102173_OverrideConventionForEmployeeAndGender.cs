namespace Employee2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionForEmployeeAndGender : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "EmployeeUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Employees", new[] { "EmployeeUser_Id" });
            DropIndex("dbo.Employees", new[] { "Gender_Id" });
            AlterColumn("dbo.Employees", "SurName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Employees", "FatherName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Employees", "MotherName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Employees", "Birthplace", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Employees", "EmployeeUser_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Employees", "Gender_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Genders", "GenderName", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Employees", "EmployeeUser_Id");
            CreateIndex("dbo.Employees", "Gender_Id");
            AddForeignKey("dbo.Employees", "EmployeeUser_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Employees", "EmployeeUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Employees", new[] { "Gender_Id" });
            DropIndex("dbo.Employees", new[] { "EmployeeUser_Id" });
            AlterColumn("dbo.Genders", "GenderName", c => c.String());
            AlterColumn("dbo.Employees", "Gender_Id", c => c.Int());
            AlterColumn("dbo.Employees", "EmployeeUser_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Employees", "Birthplace", c => c.String());
            AlterColumn("dbo.Employees", "MotherName", c => c.String());
            AlterColumn("dbo.Employees", "FatherName", c => c.String());
            AlterColumn("dbo.Employees", "SurName", c => c.String());
            CreateIndex("dbo.Employees", "Gender_Id");
            CreateIndex("dbo.Employees", "EmployeeUser_Id");
            AddForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders", "Id");
            AddForeignKey("dbo.Employees", "EmployeeUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}

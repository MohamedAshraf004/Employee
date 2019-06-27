namespace Employee2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEmployeeAndGenderTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SurName = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        Birthplace = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        EmployeeUser_Id = c.String(maxLength: 128),
                        Gender_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.EmployeeUser_Id)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .Index(t => t.EmployeeUser_Id)
                .Index(t => t.Gender_Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenderName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Employees", "EmployeeUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Employees", new[] { "Gender_Id" });
            DropIndex("dbo.Employees", new[] { "EmployeeUser_Id" });
            DropTable("dbo.Genders");
            DropTable("dbo.Employees");
        }
    }
}

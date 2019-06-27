namespace Employee2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToEmployee : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "BloodGroup_Id", newName: "BloodGroupId");
            RenameColumn(table: "dbo.Employees", name: "EmployeeUser_Id", newName: "EmployeeUserId");
            RenameColumn(table: "dbo.Employees", name: "Gender_Id", newName: "GenderId");
            RenameIndex(table: "dbo.Employees", name: "IX_EmployeeUser_Id", newName: "IX_EmployeeUserId");
            RenameIndex(table: "dbo.Employees", name: "IX_Gender_Id", newName: "IX_GenderId");
            RenameIndex(table: "dbo.Employees", name: "IX_BloodGroup_Id", newName: "IX_BloodGroupId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employees", name: "IX_BloodGroupId", newName: "IX_BloodGroup_Id");
            RenameIndex(table: "dbo.Employees", name: "IX_GenderId", newName: "IX_Gender_Id");
            RenameIndex(table: "dbo.Employees", name: "IX_EmployeeUserId", newName: "IX_EmployeeUser_Id");
            RenameColumn(table: "dbo.Employees", name: "GenderId", newName: "Gender_Id");
            RenameColumn(table: "dbo.Employees", name: "EmployeeUserId", newName: "EmployeeUser_Id");
            RenameColumn(table: "dbo.Employees", name: "BloodGroupId", newName: "BloodGroup_Id");
        }
    }
}

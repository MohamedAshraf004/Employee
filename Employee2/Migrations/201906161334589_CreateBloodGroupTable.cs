namespace Employee2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBloodGroupTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "BloodGroup_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "BloodGroup_Id");
            AddForeignKey("dbo.Employees", "BloodGroup_Id", "dbo.BloodGroups", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "BloodGroup_Id", "dbo.BloodGroups");
            DropIndex("dbo.Employees", new[] { "BloodGroup_Id" });
            DropColumn("dbo.Employees", "BloodGroup_Id");
            DropTable("dbo.BloodGroups");
        }
    }
}

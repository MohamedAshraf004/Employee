namespace Employee2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGenderTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders (GenderName) VALUES('Male')");
            Sql("INSERT INTO Genders (GenderName) VALUES('Famele')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genders WHERE Id(1,2)");
        }
    }
}

namespace Employee2.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddDataToBloodGroup : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BloodGroups(Name) VALUES('O')");
            Sql("INSERT INTO BloodGroups(Name) VALUES('A')");
            Sql("INSERT INTO BloodGroups(Name) VALUES('B')");
            Sql("INSERT INTO BloodGroups(Name) VALUES('AB')");



        }

        public override void Down()
        {
            Sql("DELETE FROM BloodGroups WHERE Id IN(1,2,3,4)");
        }
    }
}

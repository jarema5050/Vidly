namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dropcolumn : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Customers DROP CONSTRAINT DF__Customers__Birth__6E01572D");
            Sql("alter table Customers drop column BirthDate");
        }
        
        public override void Down()
        {
        }
    }
}

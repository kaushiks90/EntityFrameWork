namespace FrameworkEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataInStudentTable : DbMigration
    {
        public override void Up()
        {
            // Sql("Insert into Student (FirstName,LastName,AddressId) values(Kaushik,S,1)");
            // Sql("INSERT INTO [dbo].[Students]([FirstName],[LastName],[AddressId])VALUES(Kaushik,S,1)");
            
            Sql("INSERT INTO  dbo.Students VALUES('Kaushik','S',1)");
        }
        
        public override void Down()
        {
            Sql("delete from dbo.Students where FirstName='kaushik' and LastName='s'");
        }
    }
}

namespace FrameworkEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedStudentTable : DbMigration
    {
        public override void Up()
        {
            Sql("SELECT * INTO dbo._students  FROM dbo.students");
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        AddressId2 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);

            //Sql("Insert INTO dbo.students(FirstName,LastName,AddressId2) select (FirstName,LastName,AddressId2)  FROM dbo._students");
            Sql("Insert INTO dbo.students  select FirstName,LastName,AddressId2  FROM dbo._students");
            DropTable("dbo._Students");

        }
    }
}

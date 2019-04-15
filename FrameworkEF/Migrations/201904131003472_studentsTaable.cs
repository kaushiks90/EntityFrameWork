namespace FrameworkEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentsTaable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Grade_GradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "Grade_GradeId" });
            AddColumn("dbo.Students", "FirstName", c => c.String());
            AddColumn("dbo.Students", "LastName", c => c.String());
            AddColumn("dbo.Students", "AddressId", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "StudentName");
            DropColumn("dbo.Students", "DateOfBirth");
            DropColumn("dbo.Students", "Photo");
            DropColumn("dbo.Students", "Height");
            DropColumn("dbo.Students", "Weight");
            DropColumn("dbo.Students", "Grade_GradeId");
            DropTable("dbo.Grades");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        GradeName = c.String(),
                        Section = c.String(),
                    })
                .PrimaryKey(t => t.GradeId);
            
            AddColumn("dbo.Students", "Grade_GradeId", c => c.Int());
            AddColumn("dbo.Students", "Weight", c => c.Single(nullable: false));
            AddColumn("dbo.Students", "Height", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Students", "Photo", c => c.Binary());
            AddColumn("dbo.Students", "DateOfBirth", c => c.DateTime());
            AddColumn("dbo.Students", "StudentName", c => c.String());
            DropColumn("dbo.Students", "AddressId");
            DropColumn("dbo.Students", "LastName");
            DropColumn("dbo.Students", "FirstName");
            CreateIndex("dbo.Students", "Grade_GradeId");
            AddForeignKey("dbo.Students", "Grade_GradeId", "dbo.Grades", "GradeId");
        }
    }
}

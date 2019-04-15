namespace FrameworkEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedSubjectTable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Subject");
            AddColumn("dbo.Subject", "AuthorName", c => c.String(nullable: false));
            AlterColumn("dbo.Subject", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Subject", "Id");
            DropColumn("dbo.Subject", "SubjectId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subject", "SubjectId", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.Subject");
            AlterColumn("dbo.Subject", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.Subject", "AuthorName");
            AddPrimaryKey("dbo.Subject", new[] { "Id", "SubjectId" });
        }
    }
}

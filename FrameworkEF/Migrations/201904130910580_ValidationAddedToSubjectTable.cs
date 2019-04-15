namespace FrameworkEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidationAddedToSubjectTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Subjects", newName: "Subject");
            DropPrimaryKey("dbo.Subject");
            AddColumn("dbo.Subject", "SubjectId", c => c.Int(nullable: false));
            AlterColumn("dbo.Subject", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Subject", "Name", c => c.String());
            AddPrimaryKey("dbo.Subject", new[] { "Id", "SubjectId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Subject");
            AlterColumn("dbo.Subject", "Name", c => c.Int(nullable: false));
            AlterColumn("dbo.Subject", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Subject", "SubjectId");
            AddPrimaryKey("dbo.Subject", "Id");
            RenameTable(name: "dbo.Subject", newName: "Subjects");
        }
    }
}

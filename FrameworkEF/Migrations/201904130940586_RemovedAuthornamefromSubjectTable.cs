namespace FrameworkEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedAuthornamefromSubjectTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Subject", "AuthorName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subject", "AuthorName", c => c.String(nullable: false));
        }
    }
}

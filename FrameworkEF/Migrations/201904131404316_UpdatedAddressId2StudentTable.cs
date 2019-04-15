namespace FrameworkEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedAddressId2StudentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "AddressId2", c => c.Int(nullable: false));
            Sql("update dbo.Students set AddressId2=AddressId");
            DropColumn("dbo.Students", "AddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "AddressId", c => c.Int(nullable: false));
            Sql("update dbo.Students set AddressId=AddressId2");
            DropColumn("dbo.Students", "AddressId2");
        }
    }
}

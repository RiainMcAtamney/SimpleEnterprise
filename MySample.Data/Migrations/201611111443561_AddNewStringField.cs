namespace MySample.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewStringField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "newStringField", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "newStringField");
        }
    }
}

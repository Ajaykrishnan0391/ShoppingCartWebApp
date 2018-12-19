namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Products", newSchema: "Practice");
        }
        
        public override void Down()
        {
            MoveTable(name: "Practice.Products", newSchema: "dbo");
        }
    }
}

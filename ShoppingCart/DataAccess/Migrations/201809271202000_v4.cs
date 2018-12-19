namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Practice.ProductCategories",
                c => new
                    {
                        ProductCategoryId = c.Long(nullable: false, identity: true),
                        ProductCategoryName = c.String(),
                    })
                .PrimaryKey(t => t.ProductCategoryId);
            
            AddColumn("Practice.Products", "ProductCategory_ProductCategoryId", c => c.Long());
            CreateIndex("Practice.Products", "ProductCategory_ProductCategoryId");
            AddForeignKey("Practice.Products", "ProductCategory_ProductCategoryId", "Practice.ProductCategories", "ProductCategoryId");
            DropColumn("Practice.Products", "ProductCategory");
        }
        
        public override void Down()
        {
            AddColumn("Practice.Products", "ProductCategory", c => c.Long(nullable: false));
            DropForeignKey("Practice.Products", "ProductCategory_ProductCategoryId", "Practice.ProductCategories");
            DropIndex("Practice.Products", new[] { "ProductCategory_ProductCategoryId" });
            DropColumn("Practice.Products", "ProductCategory_ProductCategoryId");
            DropTable("Practice.ProductCategories");
        }
    }
}

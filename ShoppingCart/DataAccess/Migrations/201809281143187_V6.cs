namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Practice.Products", "ProductCategory_ProductCategoryId", "Practice.ProductCategories");
            DropIndex("Practice.Products", new[] { "ProductCategory_ProductCategoryId" });
            CreateTable(
                "Practice.Categories",
                c => new
                    {
                        CategoryId = c.Long(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            AddColumn("Practice.ProductCategories", "ProductId", c => c.Long(nullable: false));
            AddColumn("Practice.ProductCategories", "CategoryId", c => c.Long(nullable: false));
            CreateIndex("Practice.ProductCategories", "ProductId");
            CreateIndex("Practice.ProductCategories", "CategoryId");
            AddForeignKey("Practice.ProductCategories", "CategoryId", "Practice.Categories", "CategoryId", cascadeDelete: true);
            AddForeignKey("Practice.ProductCategories", "ProductId", "Practice.Products", "ProductId", cascadeDelete: true);
            DropColumn("Practice.ProductCategories", "ProductCategoryName");
            DropColumn("Practice.Products", "ProductCategory_ProductCategoryId");
        }
        
        public override void Down()
        {
            AddColumn("Practice.Products", "ProductCategory_ProductCategoryId", c => c.Long());
            AddColumn("Practice.ProductCategories", "ProductCategoryName", c => c.String());
            DropForeignKey("Practice.ProductCategories", "ProductId", "Practice.Products");
            DropForeignKey("Practice.ProductCategories", "CategoryId", "Practice.Categories");
            DropIndex("Practice.ProductCategories", new[] { "CategoryId" });
            DropIndex("Practice.ProductCategories", new[] { "ProductId" });
            DropColumn("Practice.ProductCategories", "CategoryId");
            DropColumn("Practice.ProductCategories", "ProductId");
            DropTable("Practice.Categories");
            CreateIndex("Practice.Products", "ProductCategory_ProductCategoryId");
            AddForeignKey("Practice.Products", "ProductCategory_ProductCategoryId", "Practice.ProductCategories", "ProductCategoryId");
        }
    }
}

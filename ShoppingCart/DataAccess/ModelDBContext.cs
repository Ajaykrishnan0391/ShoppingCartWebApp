using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Models;

namespace DataAccess
{
    public class ModelDBContext : DbContext
    {
        public ModelDBContext() : base("ShoppingCart")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ModelDBContext, Migrations.Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<ModelDBContext>());
            //Database.Delete();
            //Database.Create();
        }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<ProductCategory> ProductCategories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Practice");

        }
    }
}

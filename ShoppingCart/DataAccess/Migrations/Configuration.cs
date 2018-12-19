namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.ModelDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DataAccess.ModelDBContext";
        }

        protected override void Seed(DataAccess.ModelDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            /*
             * 
               delete from [Practice].[ProductCategories]
                delete from [Practice].[Categories]
                delete from [Practice].[Products]

                insert into [Practice].[Products]( [ProductName]) values('MI NOTE 3')
                insert into [Practice].[Products]( [ProductName]) values('MI NOTE 4')
                insert into [Practice].[Products]( [ProductName]) values('MI NOTE 5')
                insert into [Practice].[Products]( [ProductName]) values('VU')
                insert into [Practice].[Products]( [ProductName]) values('VU')

                insert into [Practice].[Categories]([CategoryName]) values ('Mobile Phone')
                insert into [Practice].[Categories]([CategoryName]) values ('Electronics')
                insert into [Practice].[Categories]([CategoryName]) values ('TV')

                insert into [Practice].[ProductCategories] ([ProductId],[CategoryId]) values(1,1)
                insert into [Practice].[ProductCategories] ([ProductId],[CategoryId]) values(1,2)
                insert into [Practice].[ProductCategories] ([ProductId],[CategoryId]) values(2,1)
                insert into [Practice].[ProductCategories] ([ProductId],[CategoryId]) values(2,2)
                insert into [Practice].[ProductCategories] ([ProductId],[CategoryId]) values(3,1)
                insert into [Practice].[ProductCategories] ([ProductId],[CategoryId]) values(3,2)
                insert into [Practice].[ProductCategories] ([ProductId],[CategoryId]) values(4,2)
                insert into [Practice].[ProductCategories] ([ProductId],[CategoryId]) values(4,3)
                insert into [Practice].[ProductCategories] ([ProductId],[CategoryId]) values(5,2)
                insert into [Practice].[ProductCategories] ([ProductId],[CategoryId]) values(5,3)
             **/
        }
    }
}

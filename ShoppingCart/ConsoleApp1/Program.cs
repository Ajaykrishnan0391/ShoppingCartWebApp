using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a2 = GetProducts();
            var a = GetProducts().ToList();
            ModelDBContext obj = new ModelDBContext();
            var query1 = obj.Products.Include("ProductCategories").ToList();
            //var query = obj.Products.Include("ProductCategories").Include("Category").ToList();

            var query2 = (from product in obj.Products
                          from productCategory in product.ProductCategories
                          select new
                          {
                              productName = product.ProductName,
                              CategoryName = productCategory.Category.CategoryName
                          }).ToList();
            var a1 = 10;
        }
        static IQueryable<ProductVM> GetProducts()
        {
            
            ModelDBContext obj = new ModelDBContext();
            var a = obj.Products;
            var products = (from product in obj.Products
                            select new ProductVM
                            {
                                ProductId = product.ProductId,
                                ProductName = product.ProductName,
                                ProductCategories = obj.ProductCategories.Where(x => x.ProductId == product.ProductId).Select(x => x)
                            });
            
            return products;

        }
    }
    public class ProductVM
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public IQueryable<ProductCategory> ProductCategories { get; set; }
    }
}

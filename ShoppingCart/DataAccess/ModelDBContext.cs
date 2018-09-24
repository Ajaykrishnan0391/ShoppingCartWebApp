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

        }
        public IDbSet<Product> Products { get; set; }
    }
}

using System.Collections.Generic;

namespace Models
{
    public class Category
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    
    [Table("ProductCategory", Schema="production")]
    public class Category
    {
        [Key]
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdminLTE2.Models
{
    public class Products
    {
        [Key]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string? description { get; set; }
        public decimal? standard_cost { get; set; }
        public decimal? list_price { get; set; }

        [ForeignKey("Product_Categories")]
        public int category_id { get; set; }
        public Product_Categories? Product_Categories { get; set; }
        
    }
}

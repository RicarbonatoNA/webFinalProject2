using System.ComponentModel.DataAnnotations;
namespace AdminLTE2.Models
{
    public class Product_Categories
    {
        [Key]
        public int category_id { get; set; }
        public string category_name { get; set; }
    }
}

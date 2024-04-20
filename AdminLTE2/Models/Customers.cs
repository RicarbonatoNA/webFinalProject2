using System.ComponentModel.DataAnnotations;

namespace AdminLTE2.Models
{
    public class Customers
    {
        [Key]
        public int customer_id { get; set; }
        public string name { get; set; }
        public string? address { get; set; }
        public string? website { get; set; }
        public decimal? credit_limit { get; set; }
    }
}

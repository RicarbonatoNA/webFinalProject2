using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdminLTE2.Models
{
    public class Orders
    {
        [Key]
        public int order_id { get; set; }

        [ForeignKey("Customers")]
        public int customer_id { get; set; }
        public Customers? Customers { get; set; }

        public string status { get; set; }

        [ForeignKey("Employees")]
        public int? salesman_id { get; set; }
        public Employees? Employees { get; set; }
        public DateTime order_date { get; set; }



    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdminLTE2.Models
{
    public class Contacts
    {
        [Key]
        public int contact_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string? phone { get; set; }

        [ForeignKey("Customers")]
        public int? customer_id { get; set; }
        public Customers? Customers { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdminLTE2.Models
{
    public class Warehouses
    {
        [Key]
        public int warehouse_id { get; set; }
        public string? warehouse_name { get; set; }

        [ForeignKey("Locations")]
        public int? location_id { get; set; }
        public Locations? Locations { get; set; }
    }
}

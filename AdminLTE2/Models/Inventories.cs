using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminLTE2.Models
{
    [Keyless]
    public class Inventories
    {
        //[Key]
        [ForeignKey("Products")]
        public int product_id { get; set; }
        public Products? Products { get; set; }
        //[Key]
        [ForeignKey("Warehouses")]
        public int warehouse_id { get; set; }
        public Warehouses? Warehouses { get; set; }
        public int quantity { get; set; }
    }
}

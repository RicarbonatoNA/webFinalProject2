using System.ComponentModel.DataAnnotations;
namespace AdminLTE2.Models
{
    public class Regions
    {
        [Key]
        public int region_id { get; set; }
        public string region_name { get; set; }
    }
}

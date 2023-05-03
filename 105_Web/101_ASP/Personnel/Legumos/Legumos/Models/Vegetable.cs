using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legumos.Models
{
    [Table("tbl_vegetables")]
    public class Vegetable
    {
        [Key]
        public int VegetableId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Variety { get; set; }
        public string PrimaryColor { get; set; }
        public int Lifetime { get; set; } 
        public int Fresh { get; set; }
        public float Price { get; set; }
    }
}

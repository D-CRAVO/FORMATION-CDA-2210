using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CerealsApi.Models
{
    [Table("tbl_cereals")]
    public class Cereal : Model
    {
        [Key]
        public int CerealId { get => base.Id; }

        [Required]
        //[Column("nom_de_la_colonne_dans_la_base_de_donnees")]
        [RegularExpression(@"^[A-Z][a-z]*$")]
        public string Name { get; set; }

        [Required]
        public int Calories { get; set; }

        [Required]
        public int Protein { get; set; }
    }
}

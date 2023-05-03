using System.ComponentModel.DataAnnotations;

namespace CerealsApi.Models
{
    public abstract class Model
    {
        [Key]
        public int Id { get; set; }

    }
}

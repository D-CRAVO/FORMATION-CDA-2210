using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public DateTime Year { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Actor { get; set; }
        public string 
    }
}

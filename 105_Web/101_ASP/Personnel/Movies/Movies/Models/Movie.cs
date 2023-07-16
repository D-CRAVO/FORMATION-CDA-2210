using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
    [Table ("tbl_movies")]
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required][Column ("movie_year")]
        public DateTime Year { get; set; }
        [Column ("movie_length")]
        public int Length { get; set; }
        [Required][Column ("movie_title")]
        public string Title { get; set; }
        [Column ("movie_subject")]
        public string Subject { get; set; }
        [Column ("movie_actor")]
        public string Actor { get; set; }
        [Column ("movie_actress")]
        public string Actress { get; set; }
        [Column ("movie_director")]
        public string Director { get; set; }
        [Column ("movie_popularity")]
        public int Popularity { get; set; }
        [Column ("movie_awards")]
        public bool Awards { get; set; }
    }
}

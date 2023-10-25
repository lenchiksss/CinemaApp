using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Director { get; set; }

        [Required] 
        public string Genre { get; set; }

        [Required] 
        public string Description { get; set; }

        [Required]
        public DateTime Showtime { get; set; }
    }
}
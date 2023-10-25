using System.ComponentModel.DataAnnotations;

namespace CinemaApp.ViewModels
{
    public class MovieViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public DateTime Showtime { get; set; }
    }
}
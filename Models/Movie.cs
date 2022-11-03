using System.ComponentModel.DataAnnotations;

namespace CO550_MOVIES_MVC.Models
{
    public enum Genres
    {
        Action, Comedy, Drama, Horror, Romance
    }
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public Genres Genre { get; set; }

        [Range(5.99, 8.99), Required]
        public decimal Price { get; set; }
    }
}

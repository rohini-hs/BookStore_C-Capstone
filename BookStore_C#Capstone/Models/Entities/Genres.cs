using System.ComponentModel.DataAnnotations;

namespace BookStore_C_Capstone.Models.Entities
{
    public class Genres
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        [StringLength(255)]
        public string GenreName { get; set; } // Changed from Name to GenreName for clarity

        public ICollection<Books> Books { get; set; }
    }
}

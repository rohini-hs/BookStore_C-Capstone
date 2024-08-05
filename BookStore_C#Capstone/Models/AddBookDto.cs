using BookStore_C_Capstone.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore_C_Capstone.Models
{
    public class AddBookDto
    {
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
    }
}

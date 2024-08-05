using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore_C_Capstone.Models.Entities
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
  

        [ForeignKey("Genre")]
        public int GenreId { get; set; }
     
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BookStore_C_Capstone.Models.Entities
{
    public class Authors
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Biography { get; set; } 

        public ICollection<Books> Books { get; set; }
    }
}

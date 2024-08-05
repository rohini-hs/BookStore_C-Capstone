using BookStore_C_Capstone.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore_C_Capstone.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Genres> Genres { get; set; }

    }
}

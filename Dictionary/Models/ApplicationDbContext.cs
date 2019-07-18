using Microsoft.EntityFrameworkCore;

namespace Dictionary.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Word> Words { get; set; }
        public DbSet<Meaning> Meanings { get; set; }
    }
}

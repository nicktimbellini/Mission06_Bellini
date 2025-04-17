using Microsoft.EntityFrameworkCore;
using Mission06_Bellini.Models;

namespace Mission06_Bellini.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }  // ✅ Add this line for foreign key support

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}

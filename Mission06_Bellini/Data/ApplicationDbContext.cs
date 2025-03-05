using Microsoft.EntityFrameworkCore;
using Mission06_Bellini.Models;

namespace Mission06_Bellini.Data // ✅ Ensure this matches your project name
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "Inception", Category = "Sci-Fi", Year = 2010, Director = "Christopher Nolan", Rating = "PG-13", LentTo = null, Notes = null },
                new Movie { MovieId = 2, Title = "The Dark Knight", Category = "Action", Year = 2008, Director = "Christopher Nolan", Rating = "PG-13", LentTo = null, Notes = null },
                new Movie { MovieId = 3, Title = "Interstellar", Category = "Sci-Fi", Year = 2014, Director = "Christopher Nolan", Rating = "PG-13", LentTo = null, Notes = null }
            );
        }

    }


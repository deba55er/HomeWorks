using HomeWork1_RazorPagesMovies.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork1_RazorPagesMovies.Data
{
    public class RazorPagesMoviesContext : DbContext
    {
        public RazorPagesMoviesContext (DbContextOptions<RazorPagesMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}

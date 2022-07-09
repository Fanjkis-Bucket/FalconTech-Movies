using Microsoft.EntityFrameworkCore;
using MoviesDAT;

namespace Movies.DAL
{
    public class MovieDBContext : DbContext
    { 

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public MovieDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}

using System.Data.Entity;


namespace SoPro.Models
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Client> Clients { get; set; }



        public MovieDbContext() : base("DefaultConnection") { }

        public static MovieDbContext Create()
        {
            return new MovieDbContext();
        }
    }
}

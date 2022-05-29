using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoPro.Models;

namespace SoPro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SoPro.Models.Movie>? Movie { get; set; }
        public DbSet<SoPro.Models.Client>? Client { get; set; }
    }
}
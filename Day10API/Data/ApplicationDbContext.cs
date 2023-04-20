using Day10API.Models;
using Microsoft.EntityFrameworkCore;

namespace Day10API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }

}

using CinemaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
            new DbInitializer(modelBuilder).Seed();
        }
    }
}
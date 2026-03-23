using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class SkiContext : DbContext
    {
        public SkiContext(DbContextOptions<SkiContext> options) : base(options) { }

        public DbSet<Resort> Resorts { get; set; }
    }
}

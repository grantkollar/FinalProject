using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class SkiContext : DbContext
    {
        public SkiContext(DbContextOptions<SkiContext> options) : base(options) { }

        public DbSet<Resort> Resorts { get; set; }

        // seed the database with some resort data on first migration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Resort>().HasData(
                new Resort { ResortId = 1, Name = "Vail", State = "Colorado", VerticalDrop = 3450, NumberOfRuns = 195, AnnualSnowfall = 354, Difficulty = "Advanced" },
                new Resort { ResortId = 2, Name = "Park City Mountain", State = "Utah", VerticalDrop = 3226, NumberOfRuns = 341, AnnualSnowfall = 355, Difficulty = "Intermediate" },
                new Resort { ResortId = 3, Name = "Breckenridge", State = "Colorado", VerticalDrop = 3398, NumberOfRuns = 187, AnnualSnowfall = 300, Difficulty = "Intermediate" },
                new Resort { ResortId = 4, Name = "Mammoth Mountain", State = "California", VerticalDrop = 3100, NumberOfRuns = 175, AnnualSnowfall = 400, Difficulty = "Advanced" },
                new Resort { ResortId = 5, Name = "Jackson Hole", State = "Wyoming", VerticalDrop = 4139, NumberOfRuns = 131, AnnualSnowfall = 459, Difficulty = "Expert" },
                new Resort { ResortId = 6, Name = "Steamboat Springs", State = "Colorado", VerticalDrop = 3668, NumberOfRuns = 169, AnnualSnowfall = 349, Difficulty = "Intermediate" }
            );
        }
    }
}

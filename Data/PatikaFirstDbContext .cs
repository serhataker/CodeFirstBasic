using CodeFirstBasic.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Data
{
    public class PatikaFirstDbContext:DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext>options):base(options) { } // we defined the options for the appsettng.json setting

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .Property(g => g.Rating)
                .HasColumnType("decimal(18, 2)"); // we create for the rating decimal type
        }


        public DbSet<Game> Games { get; set; } // we defined the Games tables for the our DB
        public DbSet<Movie> Movies { get; set; } //we defined the Movies tables for the our DB
    }
}

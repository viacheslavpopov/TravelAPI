using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
    public class TravelAPIContext : DbContext
    {
        public TravelAPIContext(DbContextOptions<TravelAPIContext> options) : base(options)
        {
        }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<Destination> Destinations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Review>()

                .HasData(
                    new Review { }
                );

            builder.Entity<Destination>()

                .HasData(
                    new Destination { }
                );
        }
    }
}
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic; //gets List<Review> squiggly to go away but added ReviewId squiggly
using System.Linq;

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
                    new Review { ReviewId = 1, Title = "Review #01", Rating = 4, Body = "Pretty good." , WouldRecommend = true , DestinationId = 1},
                    new Review { ReviewId = 2, Title = "Review #02", Rating = 2, Body = "Pretty bad." , WouldRecommend = false , DestinationId = 2},
                    new Review { ReviewId = 3, Title = "Review #03", Rating = 5, Body = "Amaaaaaaaazing" , WouldRecommend = true , DestinationId = 3},
                    new Review { ReviewId = 4, Title = "Review #04", Rating = 3, Body = "Middle of the Road" , WouldRecommend = false , DestinationId = 2}
                );

            builder.Entity<Destination>()

                .HasData(
                    new Destination { DestinationId = 1, City = "Barcelona", State = "Catalonia", Country = "Spain" },
                    new Destination { DestinationId = 2, City = "Portland", State = "Oregon", Country = "USA" },
                    new Destination { DestinationId = 3, City = "Denpasar", State = "", Country = "Bali"},
                    new Destination { DestinationId = 4, City = "Helsinki", State = "Etela Province", Country = "Finland" },
                    new Destination { DestinationId = 5, City = "Perth", State = "Western Australia", Country = "Australia"}
                );
        }
    }
}
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
                    new Review { ReviewId = 1, Title = "Review #01", Rating = 5, Body = "Pretty good." , WouldRecommend = true , DestinationId = 1}
                );

            builder.Entity<Destination>()

                .HasData(
                    new Destination { DestinationId = 1, City = "Barcelona", State = "Catalonia", Country = "Spain" } //, Reviews = new List<Review> { ReviewId = 1, ReviewId = 2, ReviewId = 3 } }
                );

                //so far tried...
                //List<Reviews> BarcelonaReviews = new List<Review>
                //Reviews = {1, 2, 3}
                //Reviews = {ReviewId = 1, 2, 3}
                //Reviews = {ReviewId = 1, ReviewId = 2, ReviewId = 3}
                //Reviews = { new ReviewId = 1, 2, 3}
                 //List<Reviews> BarcelonaReviews = new List<Review>{ ReviewId = 1, ReviewId = 2, ReviewId = 3} }
                 //{ { ReviewId = 1, Title = "Review #01", Rating = 5, Body = "Pretty good." , WouldRecommend = true }, ReviewId = 2, ReviewId = 3 }
        }
    }
}
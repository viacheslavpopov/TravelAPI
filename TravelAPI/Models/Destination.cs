using System.Collections.Generic;

namespace TravelAPI.Models
{
    public class Destination
    {
        public Destination()
        {
            this.Reviews = new HashSet<Review>();
        }
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public ICollection<Review> Reviews { get; set; }

        //public int AverageReview { get; set; }
    }
}
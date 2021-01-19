namespace TravelAPI.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; } // 1-5
        public string Body { get; set; }
        public bool WouldRecommend { get; set; } = true;
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
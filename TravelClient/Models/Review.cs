using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient.Models
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

        public static List<Review> GetReviews()
        {
            var apiCallTask = ApiHelper.GetAllReviews();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

            return reviewList;
        }
    }
}

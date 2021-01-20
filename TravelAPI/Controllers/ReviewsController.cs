using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelAPI.Models;

namespace TravelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private TravelAPIContext _db;
        public ReviewsController(TravelAPIContext db)
        {
            _db = db;
        }

        // GET api/reviews
        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get(string title, int rating, bool wouldRecommend)//, Destination destination)
        {
            var query = _db.Reviews.AsQueryable();

            if (title != null)
            {
                query = query.Where(entry => entry.Title == title);
            }

            if (rating != 0)
            {
                query = query.Where(entry => entry.Rating == rating);
            }

            if (wouldRecommend == true || false)
            {
                query = query.Where(entry => entry.WouldRecommend == wouldRecommend);
            }

            // if (destination != null)
            // {
            //     query = query.Where(entry => entry.Destination == destination);
            // }

            return query.ToList();
        }

        //POST api/reviews
        [HttpPost]
        public void Post([FromBody] Review review)
        {
            _db.Reviews.Add(review);
            _db.SaveChanges();
        }

        //GET api/reviews/5
        [HttpGet("{id}")]
        public ActionResult<Review> Get(int id)
        {
            return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
        }

        // PUT api/reviews/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Review review)
        {
            review.ReviewId = id;
            _db.Entry(review).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/reviews/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
            _db.Reviews.Remove(reviewToDelete);
            _db.SaveChanges();
        }
    }
}
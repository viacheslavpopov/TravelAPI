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

        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get(string title, int rating, bool wouldRecommend, Destination destination)
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

            if (wouldRecommend == true)
            {
                query = query.Where(entry => entry.WouldRecommend == wouldRecommend);
            }

            if (wouldRecommend == false)
            {
                query = query.Where(entry => entry.WouldRecommend == wouldRecommend);
            }

            if (destination != null)
            {
                query = query.Where(entry => entry.Destination == destination);
            }

            return query.ToList();
        }

        [HttpPost]
        public void Post([FromBody] Review review)
        {
            _db.Reviews.Add(review);
            _db.SaveChanges();
        }

        [HttpGet("{id}")]
        public ActionResult<Review> Get(int id)
        {
            return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            var allReviews = Review.GetDestinations();
            return View(allReviews);
        }
    }
}
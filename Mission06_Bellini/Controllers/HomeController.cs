using Microsoft.AspNetCore.Mvc;
using Mission06_Bellini.Data;
using Mission06_Bellini.Models;
using System.Linq;

namespace Mission06_Bellini.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var movies = _context.Movies.ToList(); //  Fetch movies from the database
            return View(movies); //  Pass the movies to the view
        }
    }
}

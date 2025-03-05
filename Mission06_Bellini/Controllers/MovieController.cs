using Microsoft.AspNetCore.Mvc;
using Mission06_Bellini.Data; // ✅ Ensure this matches ApplicationDbContext namespace
using Mission06_Bellini.Models;

namespace Mission06_Bellini.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }
    }
}

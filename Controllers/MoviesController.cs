using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies.Include(m => m.Cinema).OrderBy(m => m.Name).ToListAsync();
            return View(movies);
        }

        public async Task<IActionResult> Filter()
        {
            var movies = await _context.Movies.Include(m => m.Cinema).OrderBy(m => m.Name).ToListAsync();
            return View(movies);
        }
    }
}

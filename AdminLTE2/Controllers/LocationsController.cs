using AdminLTE2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE2.Controllers
{
    public class LocationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LocationsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var locations = _context.locations.Include(l => l.Countries).ToList();
            return View(locations);
        }
    }
}

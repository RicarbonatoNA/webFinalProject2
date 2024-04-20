using AdminLTE2.Data;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE2.Controllers
{
    public class RegionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RegionsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var regions = _context.regions.AsQueryable();
            return View(regions);
        }
    }
}

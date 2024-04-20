using AdminLTE2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE2.Controllers
{
    public class WarehousesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public WarehousesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var warehouses = _context.warehouses.Include(w => w.Locations).ToList();
            return View(warehouses);
        }
    }
}

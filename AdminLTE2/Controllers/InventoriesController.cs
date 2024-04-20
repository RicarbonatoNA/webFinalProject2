using AdminLTE2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE2.Controllers
{
    public class InventoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public InventoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var inventories = _context.inventories.Include(i => i.Warehouses).ToList();
            return View(inventories);
        }
    }
}

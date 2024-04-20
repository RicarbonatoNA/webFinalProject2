using AdminLTE2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.products.Include(p => p.Product_Categories).ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            ViewData["product_id"] = new SelectList(_context.products, "product_id", "product_name");
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contacts = _context.products.Find(id);
            if (contacts == null)
            {
                return NotFound();
            }
            ViewData["product_id"] = new SelectList(_context.products, "product_id", "product_name", contacts.product_id);
            return View(contacts);
        }
    }
}

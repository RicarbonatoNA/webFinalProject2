using AdminLTE2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdminLTE2.Controllers
{
    public class Product_CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public Product_CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var product_categories = _context.product_categories.AsQueryable();
            return View(product_categories);
        }
        public IActionResult Create()
        {
            ViewData["categoty_id"] = new SelectList(_context.product_categories, "category_id", "category_name");
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contacts = _context.product_categories.Find(id);
            if (contacts == null)
            {
                return NotFound();
            }
            ViewData["category_id"] = new SelectList(_context.product_categories, "category_id", "category_name", contacts.category_id);
            return View(contacts);
        }
    }
}

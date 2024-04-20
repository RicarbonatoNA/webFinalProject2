using AdminLTE2.Data;
using Microsoft.AspNetCore.Mvc;

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
    }
}

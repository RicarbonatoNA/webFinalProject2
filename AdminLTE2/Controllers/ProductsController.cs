using AdminLTE2.Data;
using AdminLTE2.Models;
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

        // GET: CountriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Products products, string id)
        {

            if (ModelState.IsValid)
            {
                if (id == "add")
                {

                    await _context.products.AddAsync(products);
                    await _context.SaveChangesAsync();

                    TempData["mensaje"] = "El Pais se guardo correctamente";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _context.products.Update(products);
                    await _context.SaveChangesAsync();

                    TempData["mensaje"] = "Cambios guardados correctamente";
                    return RedirectToAction(nameof(Index), new { id = "" });
                }
            }

            return View(products);
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            var reg = _context.products.Find(id);
            if (reg == null)
            {
                return Json(new { success = false, message = "Algo salió mal... inténtalo de nuevo." });
            }
            else
            {

                _context.products.Remove(reg);
                _context.SaveChanges();
                return Json(new { success = true, message = "Pais eliminada exitosamente." });
            }
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerDatos()
        {
            var todos = await _context.products.Include(c => c.product_name).ToListAsync();
            return Json(new { data = todos });
        }
    }
}

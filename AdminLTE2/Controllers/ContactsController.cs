using AdminLTE2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE2.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var contacts = _context.contacts.Include(c => c.Customers).ToList();
            return View(contacts);
        }
    }
}

using CoffeeShop.DAL;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Areas.Admin.Controllers
{
    namespace CoffeeShop.Areas.Admin.Controllers
    {
        [Area("Admin")]

        public class CustomerController : Controller
        {
            public readonly AppDbContext _context;
            public CustomerController(AppDbContext context)
            {
                _context = context;


            }
            public async Task<IActionResult> Index()
            {
                IEnumerable<Customers> customers = await _context.Customers.ToListAsync();


                return View(customers);
            }
            public async Task<IActionResult> Detail(int? Id)
            {
                if (Id == null) return BadRequest();
                var customersDb = await _context.Customers.FirstOrDefaultAsync(p => p.Id == Id);
                if (customersDb == null) return NotFound();

                return View(customersDb);
            }
        }
    }

}

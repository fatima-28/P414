using CoffeeShop.Areas.Admin;
using CoffeeShop.DAL;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class ProductController : Controller
    {
        public readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;


        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products= await _context.Products.ToListAsync();
       

            return View(products);
        }
        public async Task<IActionResult> Detail(int? Id)
        {
            if (Id == null) return BadRequest();
            var productDb = await _context.Products.FirstOrDefaultAsync(p=>p.Id==Id);
            if (productDb == null) return NotFound();
           
            return View(productDb);
        }
    }
}

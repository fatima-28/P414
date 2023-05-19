using CoffeeShop.DAL;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Controllers
{

    public class CoffeeController : Controller
    {
        private readonly AppDbContext _context;
        public CoffeeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Take(4).ToListAsync();
            var countList = await _context.Products.CountAsync();
            ViewBag.countList = countList;
            return View(products);
        }
        public async Task<IActionResult> LoadMore(int skip,int take)
        {
            IEnumerable<Product> products = await _context.Products.Skip(skip).Take(take).ToListAsync();

            return PartialView("_ProductPartial", products);
        }
    }
}

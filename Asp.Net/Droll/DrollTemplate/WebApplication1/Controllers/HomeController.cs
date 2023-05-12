using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task< IActionResult> Index()
        {
            HomeVM home = new()
            {
                Products = await _context.Products.Include(p => p.ProductImages).Take(3).ToListAsync()


            };
           return View(home);
        }
        public async Task<IActionResult> ProductDetail(int? Id)
        {
            if (Id == null) return BadRequest();
            Products productDb =  _context.Products.Where(p => !p.IsDeleted).Include(m=>m.ProductImages).FirstOrDefault(p => p.Id == Id);
            if (productDb == null) return NotFound();
            return View(productDb);


        }
    }
}

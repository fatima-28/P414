using CoffeeShop.DAL;
using CoffeeShop.Models;
using CoffeeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
      
        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {   _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            HomeVm home = new()
            {
                Customers= await _context.Customers.Where(c=>!c.IsDeleted).ToListAsync()
            };
            return View(home);
        }

      
    }
}
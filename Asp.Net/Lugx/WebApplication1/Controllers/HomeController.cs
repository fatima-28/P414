using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Features f1 = new()
            {
                Id = 1,
                Logo= "featured-01.png",
                Name = "Musa"
            };
            Features f2 = new()
            {
                Id = 2,
                Logo = "featured-02.png",
                Name = "Fatime"
            };
            Features f3 = new()
            {
                Id = 3,
                Logo = "featured-03.png",
                Name = "Nicat"
            };
            Features f4 = new()
            {
                Id = 4,
                Logo = "featured-04.png",
                Name = "Nana"
            };
            Games g1 = new()
            {
                Id = 1,
                Title = "featured-01.png",
                Price =5,
                OldPrice=8,
                CategoryName="horror"
            };
            Games g2 = new()
            {
                Id = 2,
                Title = "featuruyftcgvhjkhed-03.png",
                Price = 53,
                OldPrice = 80,
                CategoryName = "love"
            };
            Games g3 = new()
            {
                Id = 3,
                Title = "featuruyftcgvhjkhed-02.png",
                Price = 150,
                OldPrice =180,
                CategoryName = "action"
            };

            HomeVM home = new()
            {
                games = new List<Games>() { g1, g2,g3 },
                features = new List<Features>() { f1, f2, f3, f4 }
            };
            return View(home);
        }
        
    }
}

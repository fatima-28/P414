using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            Categories c1 = new()
            {
                Id = 1,
                Name = "Adventure"
            };
            Categories c2 = new()
            {
                Id = 3,
                Name = "Love Story"
            };
            Categories c3 = new()
            {
                Id = 4,
                Name = "Story"
            };
            List<Categories> categories = new List<Categories>() { c1,c2, c3 };
            return View(categories);
        }
    }
}

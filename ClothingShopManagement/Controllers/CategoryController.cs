using Microsoft.AspNetCore.Mvc;
using ClothingShopManagement.Data;

namespace ClothingShopManagement.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

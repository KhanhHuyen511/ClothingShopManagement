using Microsoft.AspNetCore.Mvc;
using ClothingShopManagement.Data;

namespace ClothingShopManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CoSeClothes.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

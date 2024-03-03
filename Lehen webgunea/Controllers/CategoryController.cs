using Microsoft.AspNetCore.Mvc;

namespace Lehen_webgunea.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

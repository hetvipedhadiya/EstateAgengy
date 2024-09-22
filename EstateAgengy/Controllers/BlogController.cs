using Microsoft.AspNetCore.Mvc;

namespace EstateAgengy.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View("blog");
        }
    }
}

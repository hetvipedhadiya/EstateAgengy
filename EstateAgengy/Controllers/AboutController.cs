using Microsoft.AspNetCore.Mvc;

namespace EstateAgengy.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View("about");
        }
    }
}

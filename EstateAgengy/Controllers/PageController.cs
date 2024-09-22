using Microsoft.AspNetCore.Mvc;

namespace EstateAgengy.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View("page1");
        }

        public IActionResult Blog1()
        {
            return View();
        }

        public IActionResult AgntGrid()
        {
            return View();
        }

        public IActionResult AgntSingle()
        {
            return View();
        }
    }
}

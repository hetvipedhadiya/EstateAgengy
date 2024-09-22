using Microsoft.AspNetCore.Mvc;

namespace EstateAgengy.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View("property");
        }
    }
}

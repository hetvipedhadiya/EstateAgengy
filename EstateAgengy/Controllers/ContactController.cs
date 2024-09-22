using Microsoft.AspNetCore.Mvc;

namespace EstateAgengy.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View("contact");
        }
    }
}

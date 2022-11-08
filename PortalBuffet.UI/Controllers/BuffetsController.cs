using Microsoft.AspNetCore.Mvc;

namespace PortalBuffet.UI.Controllers
{
    public class BuffetsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HeaderName = "HeaderBuffetList";
            return View();
        }

        public IActionResult BuffetPage()
        {
            ViewBag.HeaderName = "HeaderBuffetPage";

            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace PortalBuffet.UI.Controllers
{
    public class BuffetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BuffetPage()
        {
            return View();
        }
    }
}

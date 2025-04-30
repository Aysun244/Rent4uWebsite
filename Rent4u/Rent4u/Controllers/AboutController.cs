using Microsoft.AspNetCore.Mvc;

namespace Rent4u.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Rent4u.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

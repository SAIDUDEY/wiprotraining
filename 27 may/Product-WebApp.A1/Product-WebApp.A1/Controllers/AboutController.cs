using Microsoft.AspNetCore.Mvc;

namespace Product_WebApp.A1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

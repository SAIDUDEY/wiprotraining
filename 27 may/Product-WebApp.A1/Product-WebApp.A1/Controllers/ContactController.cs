using Microsoft.AspNetCore.Mvc;
using Product_WebApp.A1.Models;

namespace Product_WebApp.A1.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Thank you for contacting us!";
                ModelState.Clear();
                return View();
            }
            return View(model);
        }
    }
}

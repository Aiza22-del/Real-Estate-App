using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult AboutUsIndex()
        {
            return View();
        }
    }
}

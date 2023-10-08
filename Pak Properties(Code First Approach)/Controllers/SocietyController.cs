using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class SocietyController : Controller
    {
        public IActionResult SocietyIndex()
        {
            return View();
        }
    }
}

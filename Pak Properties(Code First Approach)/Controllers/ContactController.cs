using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactUsIndex()
        {
            return View();
        }
    }
}

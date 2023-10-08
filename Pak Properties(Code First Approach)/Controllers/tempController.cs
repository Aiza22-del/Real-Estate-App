using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class tempController : Controller
    {
        public IActionResult tempIndex()
        {
            return View();
        }
    }
}

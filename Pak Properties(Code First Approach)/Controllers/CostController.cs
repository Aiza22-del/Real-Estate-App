using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class CostController : Controller
    {
        public IActionResult CostIndex()
        {
            return View();
        }
    }
}

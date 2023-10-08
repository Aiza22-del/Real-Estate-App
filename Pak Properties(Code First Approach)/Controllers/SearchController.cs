using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult SearchIndex()
        {
            return View();
        }
    }
}

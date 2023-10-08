using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult SearchIndex()
        {
            return View();
        }
    }
}

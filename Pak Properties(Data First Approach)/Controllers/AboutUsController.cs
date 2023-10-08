using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult AboutUsIndex()
        {
            return View();
        }
    }
}

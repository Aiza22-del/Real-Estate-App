using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult ServicesIndex()
        {
            return View();
        }
    }
}

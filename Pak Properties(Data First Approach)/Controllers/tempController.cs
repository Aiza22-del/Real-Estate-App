using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class tempController : Controller
    {
        public IActionResult tempIndex()
        {
            return View();
        }
    }
}

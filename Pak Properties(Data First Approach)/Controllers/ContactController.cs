using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactUsIndex()
        {
            return View();
        }
    }
}

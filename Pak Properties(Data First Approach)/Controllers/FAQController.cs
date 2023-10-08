using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult FAQIndex()
        {
            return View();
        }
    }
}

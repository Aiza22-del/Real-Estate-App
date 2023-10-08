using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult FAQIndex()
        {
            return View();
        }
    }
}

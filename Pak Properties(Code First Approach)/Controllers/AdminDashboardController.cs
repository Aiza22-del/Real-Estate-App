using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApplication2.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult AdminDashboardIndex()
        {
			string userEmail = HttpContext.Session.GetString("UserEmail");
			return View(userEmail);
		}
    }
}

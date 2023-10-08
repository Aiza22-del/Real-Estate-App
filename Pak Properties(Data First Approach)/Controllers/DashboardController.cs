using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
using Microsoft.AspNetCore.Http;

namespace CodeFirstApproach.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult DashboardIndex()
        {
			string userEmail = HttpContext.Session.GetString("UserEmail");
			return View(userEmail);
		}
    }
}

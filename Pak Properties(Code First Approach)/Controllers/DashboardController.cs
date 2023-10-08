using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using Microsoft.AspNetCore.Http;


namespace WebApplication2.Controllers
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

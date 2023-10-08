using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
using Microsoft.AspNetCore.Http;
namespace CodeFirstApproach.Controllers
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

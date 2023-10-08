using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;

namespace CodeFirstApproach.Controllers
{
    public class AdminLoginController : Controller
    {
        public IActionResult AdminLoginIndex()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLoginDataIndex(string Email, string Password)
        {
            AdminRepository adminRepository = new AdminRepository();
            bool flag = adminRepository.AdminVerification(Email, Password);
            if (flag == true)
            {
				HttpContext.Response.Cookies.Append("AdminEmail", Email);
				return View("~/Views/AdminDashboard/AdminDashboardIndex.cshtml");
            }
            else
            {
                return View("~/Views/AdminLogin/AdminLoginIndex.cshtml");
            }

        }

        [HttpPost]
        public IActionResult AdminRegisterIndex(string Name, string Email, string Password, string City)
        {

            AdminRepository obj = new AdminRepository();
            obj.addAdmin(Name, Email, Password, City);
            return View("~/Views/AdminDashboard/AdminDashboardIndex.cshtml");
        }
    }
}

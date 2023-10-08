using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
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
                return View("~/Views/AdminDashboard/AdminDashboardIndex.cshtml", "Welcome");
            }
            else
            {
                return View("~/Views/AdminLogin/AdminLoginIndex.cshtml", "Invalid Input");
            }

        }

        [HttpPost]
        public IActionResult AdminRegisterIndex(string Name, string Email, string Password, string City)
        {

            AdminRepository obj = new AdminRepository();
            obj.addAdmin(Name, Email, Password, City);
            return View("~/Views/AdminDashboard/AdminDashboardIndex.cshtml", "You are Successfully Registered.");
        }
    }
}

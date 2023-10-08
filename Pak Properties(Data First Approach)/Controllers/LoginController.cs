using Microsoft.IdentityModel;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginDataIndex(string Email,string Password)
        {
            UserRepository userRepository = new UserRepository();

            bool flag=userRepository.UserVerification(Email, Password);
            if(flag==true)
            {
                HttpContext.Session.SetString("UserEmail", Email);

                return View("~/Views/Dashboard/DashboardIndex.cshtml");

            }
            else
            {
                return View("~/Views/Login/LoginIndex.cshtml","invalid input");
            }
            
        }

        

        [HttpPost]
        public IActionResult RegisterIndex(string Name, string Password, string City, string ContactNo, string Email)
        {

            UserRepository obj = new UserRepository();
            obj.addUser(Name, Password, City, ContactNo, Email);
            return View("~/Views/Dashboard/DashboardIndex.cshtml","You are Successfully registered.");
        }
		public IActionResult CheckSession()
		{
			string userEmail = HttpContext.Session.GetString("UserEmail");

			if (string.IsNullOrEmpty(userEmail))
			{
				// Session is not available or empty
				return Content("Session is not available");
			}
			else
			{
				// Session is available and userEmail has a value
				return Content("Session is available. User Email: " + userEmail);
			}
		}
	}
}

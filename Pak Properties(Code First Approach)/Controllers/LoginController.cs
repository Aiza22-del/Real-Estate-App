//using Microsoft.IdentityModel;
//using WebApplication2.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http;

//namespace WebApplication2.Controllers
//{
//    public class LoginController : Controller
//    {
//        public IActionResult LoginIndex()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult LoginDataIndex(string Email,string Password)
//        {
//            UserRepository userRepository = new UserRepository();
//            bool flag=userRepository.UserVerification(Email, Password);
//            if(flag==true)
//            {
//                HttpContext.Response.Cookies.Append("UserEmail", Email);

//                return View("~/Views/Dashboard/DashboardIndex.cshtml");

//            }
//            else
//            {
//                return View("~/Views/Login/LoginIndex.cshtml","Invalid Input");
//            }            
//        }      
//        [HttpPost]
//        public IActionResult RegisterIndex(string Name, string Password, string City, string ContactNo, string Email)
//        {

//            UserRepository obj = new UserRepository();
//            obj.addUser(Name, Password, City, ContactNo, Email);
//            return View("~/Views/Dashboard/DashboardIndex.cshtml","You are Successfully Registered.");
//        }
//
//
//    }
//}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult LoginIndex()
		{
			return View();
		}

		[HttpPost]
		public IActionResult LoginDataIndex(string Email, string Password)
		{
			UserRepository userRepository = new UserRepository();
			bool flag = userRepository.UserVerification(Email, Password);
			if (flag)
			{
				// Store the user email in session
				HttpContext.Session.SetString("UserEmail", Email);

				return View("~/Views/Dashboard/DashboardIndex.cshtml");
			}
			else
			{
				return View("~/Views/Login/LoginIndex.cshtml", "Invalid Input");
			}
		}

		[HttpPost]
		public IActionResult RegisterIndex(string Name, string Password, string City, string ContactNo, string Email)
		{
			UserRepository obj = new UserRepository();
			obj.addUser(Name, Password, City, ContactNo, Email);
			return View("~/Views/Dashboard/DashboardIndex.cshtml", "You are Successfully Registered.");
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


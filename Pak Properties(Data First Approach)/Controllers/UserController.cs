using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}

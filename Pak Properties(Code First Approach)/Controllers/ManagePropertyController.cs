using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ManagePropertyController : Controller
    {
        public IActionResult RemovePropertyIndex()
        {
            return View();
        }
        public IActionResult AddPropertyIndex()
        {
            return View();
        }



        [HttpPost]
        public IActionResult AddPropertyDataIndex(string Email,string Type, string AreaSize,string City,string Address)
        {
            PropertyRepository obj = new PropertyRepository();
            obj.addProperty(Email,Type, AreaSize,City,Address);
            return View("~/Views/Dashboard/DashboardIndex.cshtml");

        }
        public IActionResult UpdatePropertyIndex()
        {
            return View();
        }
        public IActionResult UpdatePropertyDataIndex()
        {
            return View();
        }
    }
}

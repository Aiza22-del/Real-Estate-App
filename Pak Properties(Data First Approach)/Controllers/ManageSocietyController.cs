using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class ManageSocietyController : Controller
    {
        public IActionResult AddSocietyIndex()
        {
            return View();
        }
        public IActionResult RemoveSocietyIndex()
        {
            return View();
        }
        public IActionResult UpdateSocietyIndex()
        {
            return View();
        }
        public IActionResult UpdateSocietyDataIndex()
        {
            return View();
        }
    }
}

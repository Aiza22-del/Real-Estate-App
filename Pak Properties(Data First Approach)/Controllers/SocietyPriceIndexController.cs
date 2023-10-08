using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class SocietyPriceIndexController : Controller
    {
        public IActionResult SocietyPriceRankIndex()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class CostController : Controller
    {
        public IActionResult CostIndex()
        {
            return View();
        }

		[HttpPost]
		public IActionResult CostDataIndex(double area)
        {
            CalculatorRepository calculatorRepository = new CalculatorRepository();
            List<double> ans = new List<double>();
            ans = calculatorRepository.constructionCost(area);
            
            return View("~/Views/temp/tempIndex.cshtml",ans);
        }
    }
}

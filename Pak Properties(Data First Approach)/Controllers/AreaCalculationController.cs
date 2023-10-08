using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class AreaCalculationController : Controller
    {
        public IActionResult AreaCalculationIndex()
        {
            return View();
        }

		[HttpPost]
		public IActionResult AreaCalculationDataIndex(int requiredID,int area,string required)
		{
			CalculatorRepository calculatorRepository = new CalculatorRepository();
			double areaSum = 0;
			Console.WriteLine("******************************************************************");
			Console.WriteLine(area);
			Console.WriteLine(requiredID);
			Console.WriteLine(required);
			areaSum = calculatorRepository.areaConverter(area, required);
			Console.WriteLine("******************************************************************");
			Console.WriteLine(areaSum);
			ViewData["Message"] = $"{area} {required} is equal to {areaSum} square feet\n";
			return View("~/Views/AreaCalculation/areaCalculationResultIndex.cshtml",areaSum);
		}
	}
}

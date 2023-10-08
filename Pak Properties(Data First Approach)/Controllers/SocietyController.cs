using Microsoft.AspNetCore.Mvc;
using System.Collections;
using CodeFirstApproach.Models;

namespace CodeFirstApproach.Controllers
{
    public class SocietyController : Controller
    {
		

		public IActionResult SocietyIndex()
        {
            return View();
        }

/*
		[HttpPost]
		public IActionResult SocietyDataIndex(string Name,string City,string Address,string Properties,IFormFile img)
		{

			ArrayList li = new ArrayList();
			li.Add(HttpContext.Request.Cookies["PropertyName"]);
			string path = "";
			path = Path.Combine(this.Environment.WebRootPath, "~/images/societyImages");
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			string FileName = img.FileName;

			// combining GUID to create unique name before saving in wwwroot

			// getting full path inside wwwroot/images
			var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/try", FileName);
			string imgpath = "/images/try/" + FileName;
			// copying file
			FileStream n = new FileStream(imagePath, FileMode.Create);
			img.CopyTo(n);
			n.Close();
			//string i = imagePath.ToString();
			SocietyRepository obj = new SocietyRepository();
			obj.AddSociety( Name,  City,  Address,  Properties,  img);
			ViewData["Message"] = $"Society details is successfully saved.\n";
			return View("~/Views/Society/SocietyIndex.cshtml");
		}*/
	}
	
}

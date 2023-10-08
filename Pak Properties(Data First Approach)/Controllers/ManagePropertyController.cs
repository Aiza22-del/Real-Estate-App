using Microsoft.AspNetCore.Mvc;
using System.Net;
using CodeFirstApproach.Models;

namespace CodeFirstApproach.Controllers
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
        public IActionResult UpdatePropertyIndex()
        {
            return View();
        }
        public IActionResult UpdatePropertyDataIndex()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RemovePropertyDataIndex(int Id)
        {
            PropertyRepository repository = new PropertyRepository();
            bool flag=repository.RemoveProperty(Id);
            Console.WriteLine("in remove proprty data index________________________________$$$$$$$$$$$$$$$$$$$$$$$$$");
            if(flag)
            {
                Console.WriteLine("in flag =true proprty data index________________________________$$$$$$$$$$$$$$$$$$$$$$$$$");
                return View("~/Views/ManageProperty/RemovePropertyIndex.cshtml", "Property successfully removed.");
            }
            else
            {
                return View("~/Views/ManageProperty/RemovePropertyIndex.cshtml", "Error!! cannot remove this property.");
            }
            
        }


        [HttpPost]
        public IActionResult AddPropertyDataIndex(string Email,string Type, string AreaSize,string City,string Address)
        {
            PropertyRepository obj = new PropertyRepository();
            int flag=obj.addProperty(Email,Type, AreaSize,City,Address);
            if(flag!=-1)
            {
                return View("~/Views/ManageProperty/AddPropertyIndex.cshtml", flag);
            }
            else
            {
                return View("~/Views/ManageProperty/AddPropertyIndex.cshtml", "Error! add request failed");
            }
            

        }


        [HttpPost]
        public IActionResult UpdateIdCheckIndex(int ID)
        {
            PropertyRepository repository = new PropertyRepository();
            int flag = repository.checkUserId(ID);
            if (flag != -1)
            {
                return View("~/Views/ManageProperty/UpdatePropertyDataIndex.cshtml", "Id exist.");
            }
            else
            {
                return View("~/Views/ManageProperty/UpdatePropertyDataIndex.cshtml", "Error! Id doesnt exist.");
            }

        }


        [HttpPost]
        public IActionResult UpdatePropertyDatafuncIndex(string Email,int Id, string Type, string AreaSize, string City, string Address)
        {
            PropertyRepository obj = new PropertyRepository();
            Console.WriteLine("wbwgd%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%FLAG%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            bool flag = obj.UpdateProperty(Email,Id, Type, AreaSize, City, Address);
            Console.WriteLine(flag);
            if (flag)
            {
                return View("~/Views/ManageProperty/UpdatePropertyIndex.cshtml", "Property successfully updated");
            }
            else
            {
                return View("~/Views/ManageProperty/UpdatePropertyIndex.cshtml", "Error! update request failed");
            }
        }
    }
}

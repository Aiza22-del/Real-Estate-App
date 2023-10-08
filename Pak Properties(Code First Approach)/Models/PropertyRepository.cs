using System.Net;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class PropertyRepository
    {
        public void addProperty(string Email,string Type,string AreaSize,string City,string Address)
        {

            int id = getUserId(Email);
            Property obj = new Property();
            obj.Type = Type;
            obj.AreaSize = AreaSize;
            obj.City = City;
            obj.Address = Address;
            obj.UserId = id;
            RealEstateContext realEstateContext = new RealEstateContext();
            realEstateContext.Add(obj);
            realEstateContext.SaveChanges();
        }
        public int getUserId(string Email)
        {
            RealEstateContext obj = new RealEstateContext();
            var data = obj.Users.Where(a => a.Email == Email);
            int id = data.Select(u => u.Id).FirstOrDefault();
            return id;
        }
    }
}

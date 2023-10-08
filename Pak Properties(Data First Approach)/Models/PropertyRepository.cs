using System.Net;

using System.Linq;

namespace CodeFirstApproach.Models
{
    public class PropertyRepository
    {
        public int addProperty(string Email,string Type,string AreaSize,string City,string Address)
        {

            int id = getUserIdbyEmail(Email);
            Property obj = new Property();
            obj.Type = Type;
            obj.AreaSize = AreaSize;
            obj.City = City;
            obj.Address = Address;
            obj.UserId = id;
			RealEstateCFContext realEstateContext = new RealEstateCFContext();
            var  flag=realEstateContext.Properties.Add(obj);
            realEstateContext.SaveChanges();
            if(flag!=null)
            {
                
                return id;
            }
            else
            {
                return -1;
            }
        }
        public int getUserIdbyEmail(string Email)
        {
            RealEstateCFContext obj = new RealEstateCFContext();
            var data = obj.Users.Where(a => a.Email == Email);
            int id = data.Select(u => u.Id).FirstOrDefault();
            return id;
        }
        public int checkUserId(int checkId)
        {
			RealEstateCFContext obj = new RealEstateCFContext();
            
            var data = obj.Properties.FirstOrDefault(a => a.Id == checkId);
            return data.Id;
        }

        public bool RemoveProperty(int id)
        {
            RealEstateCFContext obj=new RealEstateCFContext();
            var data = obj.Properties.FirstOrDefault(a => a.Id == id);
            if (data != null)
            {
                Console.WriteLine(data.Id);
                Console.WriteLine("in id proprty data index________________________________$$$$$$$$$$$$$$$$$$$$$$$$$");
                obj.Properties.Remove(data);
                obj.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateProperty(string Email, int Id,string Type, string AreaSize,string City,string Address)
        {
            using (var context = new RealEstateCFContext())
            {
                // retrieve the record from the database
                var recordToUpdate = context.Properties.Find(Id);

                if (recordToUpdate != null)
                {
                    // update properties for the record
                    recordToUpdate.Type = Type;
                    recordToUpdate.AreaSize = AreaSize;
                    recordToUpdate.City = City;
                    recordToUpdate.Address = Address;

                    // save the changes to the database
                    context.SaveChanges();
                }
            }
            return true;
        }
    }
}

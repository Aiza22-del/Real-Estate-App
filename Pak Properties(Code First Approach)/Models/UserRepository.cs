using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class UserRepository
    {
        public void addUser(string Name,string Password,string City,string ContactNo,string Email)
        {
            User obj=new User();
            obj.Name = Name;
            obj.Email = Email;
            obj.Password = Password;
            obj.ContactNo = ContactNo;
            obj.City = City;
            RealEstateContext realEstateContext = new RealEstateContext();
            realEstateContext.Add(obj);
            realEstateContext.SaveChanges();
            
        }
        public bool UserVerification(string userEmail,string userPassword)
        {
            RealEstateContext obj = new RealEstateContext();
            Console.WriteLine($"{userEmail}     {userPassword}");

            var data=obj.Users.Where(a=> a.Email == userEmail && a.Password == userPassword);

            int val = data.Count();
            Console.WriteLine($"count {val}");

            if(data.Count()==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

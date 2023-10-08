

namespace CodeFirstApproach.Models
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
            RealEstateCFContext realEstateContext = new RealEstateCFContext();
            realEstateContext.Add(obj);
            realEstateContext.SaveChanges();
            
        }
        public bool UserVerification(string userEmail,string userPassword)
        {
			RealEstateCFContext obj = new RealEstateCFContext();
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

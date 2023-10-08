
namespace CodeFirstApproach.Models
{
    public class AdminRepository
    {
        public void addAdmin(string Name, string Email, string Password, string City)
        {
            Admin obj = new Admin();
            obj.Name = Name;
            obj.Email = Email;
            obj.Password = Password;           
            obj.City = City;
            RealEstateCFContext realEstateContext = new RealEstateCFContext();
            realEstateContext.Add(obj);
            realEstateContext.SaveChanges();
        }
        public bool AdminVerification(string userEmail, string userPassword)
        {
            RealEstateCFContext obj = new RealEstateCFContext();
            Console.WriteLine($"{userEmail}     {userPassword}");

            var data = obj.Admins.Where(a => a.Email == userEmail && a.Password == userPassword);

            int val = data.Count();
            Console.WriteLine($"count {val}");

            if (data.Count() == 0)
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

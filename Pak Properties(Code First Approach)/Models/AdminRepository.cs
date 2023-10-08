namespace WebApplication2.Models
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
            RealEstateContext realEstateContext = new RealEstateContext();
            realEstateContext.Add(obj);
            realEstateContext.SaveChanges();
        }
        public bool AdminVerification(string userEmail, string userPassword)
        {
            RealEstateContext obj = new RealEstateContext();
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

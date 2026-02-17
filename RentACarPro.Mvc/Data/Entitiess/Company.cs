using System.Runtime.ConstrainedExecution;

namespace RentACarPro.Mvc.Data.Entitiess
{
    public class Company
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Address { get; set; }
        public string LogoUrl { get; set; }

        // Admin onayı
        public bool IsVerified { get; set; } = false;

        // Şirketin arabaları ve çalışanları
        public List<Car> Cars { get; set; }
        public List<AppUser> Employees { get; set; }
    }
}

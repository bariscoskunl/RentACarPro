using Microsoft.AspNetCore.Identity;

namespace RentACarPro.Mvc.Data.Entitiess
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Eğer bu kullanıcı bir şirket sahibiyse burası dolar.
        // Müşteriyse burası boş (null) kalır.
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}

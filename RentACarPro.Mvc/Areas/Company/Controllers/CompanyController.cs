using Microsoft.AspNetCore.Mvc;

namespace RentACarPro.Mvc.Areas.Company.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace RentACarPro.Mvc.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

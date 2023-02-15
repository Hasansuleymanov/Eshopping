using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Areas.Admin.Controllers
{
    public class DashboardController :  BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

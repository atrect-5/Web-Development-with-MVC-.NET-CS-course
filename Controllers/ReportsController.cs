using Microsoft.AspNetCore.Mvc;

namespace MVCAzulSchoolProject.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

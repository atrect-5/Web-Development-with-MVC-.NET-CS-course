using Microsoft.AspNetCore.Mvc;

namespace MVCAzulSchoolProject.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

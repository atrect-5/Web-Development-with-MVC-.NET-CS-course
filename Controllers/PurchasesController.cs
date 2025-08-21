using Microsoft.AspNetCore.Mvc;

namespace MVCAzulSchoolProject.Controllers
{
    public class PurchasesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

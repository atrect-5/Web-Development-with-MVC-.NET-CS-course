using Microsoft.AspNetCore.Mvc;

namespace MVCAzulSchoolProject.Controllers
{
    public class ExpensesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

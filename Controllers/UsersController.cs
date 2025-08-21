using Microsoft.AspNetCore.Mvc;

namespace MVCAzulSchoolProject.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Unit_1_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Unit_1_Project.Models;

namespace Unit_1_Project.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayActionName(GarrettModel Model)
        {
            if (ModelState.IsValid)
            { 
                int result = (Model.Num1 * Model.Num4) - (Model.Num2 * Model.Num3); // Perform the calculation
                ViewBag.Result = result; // Pass the result to the view
            }
            return View("Display"); // Return the display view
        }
    }
}

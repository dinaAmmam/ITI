using Microsoft.AspNetCore.Mvc;
using lap2._2.Models;

namespace lap2._2.Controllers
{
    public class UtilityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id) 
        {
            if (id == 1)
            {
                return File("/images/names.txt", "text/plain", "names.txt");
            }
            else if (id == 2)  // Remove the semicolon here
            {
                return NotFound();
            }
            else if (id == 3)
            {
                return Content("content result");
            }
            else
            {
                return View();
            }

        }
        }
}

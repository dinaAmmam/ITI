using Microsoft.AspNetCore.Mvc;

namespace lap3._1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Add(Dictionary<int , int> degree) {
            return View();

        }
    }
}

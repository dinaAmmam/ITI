using Microsoft.AspNetCore.Mvc;

namespace lap1.Controllers
{
    public class StudentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public string Display()
        {
            return "first lap mvc";
        }
        public int Add(int x , int y)
        {
            return x + y;
        }
    }
}

using lap2._2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lap2._2.Controllers
{
    public class StudentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
        {
            new Student { id = 1, name = "Dina",    age = 23 },
            new Student { id = 2, name = "Mohamed", age = 47 },
            new Student { id = 3, name = "Ali",     age  = 75 }
        };

            /*List<Student> students = [
            new Student { id = 1, name = "Dina",    age = 23 },
            new Student { id = 2, name = "Mohamed", age = 47 },
            new Student { id = 3, name = "Ali",     age  = 75 } ];*/

            return View(students);
        }

        public IActionResult Details()
        {
            Student std = new Student { id = 1,name="dina", age = 23 };
            ViewBag.std = std;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Add(int id , string name , int age)
        {
            //return Content("add");
            Student std = new Student() { id = id , name = name , age = age };
            return Json(std);
        }


        public IActionResult Show()
        {
            return Json(new { x = 20, y = 30 });

        }
    }
}

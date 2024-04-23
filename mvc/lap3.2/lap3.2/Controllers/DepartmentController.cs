using lap3._2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lap3._2.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext db = new ITIContext();
        public IActionResult Index()
        {
            var model = db.departments.ToList();
            return View(model);
            //return Content("hiii");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department model)
        {
            if (model.DeptId != null && model.DeptName?.Length > 2)
            {
                db.departments.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
                //return View("index" , db.departments.ToList() );
            }
            else
                return View();
        }
    }
}

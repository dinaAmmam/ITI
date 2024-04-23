using lap4.Models;
using lap4.Reposatory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace lap4.Controllers
{
    [Authorize(Roles ="Admins")]
    public class DepartmentController : Controller
    {
        //ITIContext db = new ITIContext();
        IDeptRepo departmentRepo; // = new DepartmentRepo();
        public DepartmentController(IDeptRepo _departmentRepo)
        {
            departmentRepo = _departmentRepo;
                
        }
        public IActionResult Index()
        {
            var model = departmentRepo.GetAll();
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
            if (ModelState.IsValid)
            {
                departmentRepo.Add(model);
                return RedirectToAction("Index");
                //return View("index" , db.departments.ToList() );
                //


            }
            else
                return View(model);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
                return BadRequest();
            var model = departmentRepo.GetById(id.Value);
            if(model == null)
                return NotFound();
            return View(model);
        }
        public IActionResult Edit(int? id)
        {
            if(id == null)
                return BadRequest();
            var model = departmentRepo.GetById(id.Value);

            if (model == null)
                return NotFound();
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Department dept , int id)
        {
            dept.DeptId = id;
            departmentRepo.Update(dept);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id) 
        { 
            if(id == null)
                return BadRequest();
            departmentRepo.Delete(id.Value);
            return RedirectToAction("Index");
        }
    }

}

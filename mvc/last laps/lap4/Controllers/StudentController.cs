using lap4.Models;
using lap4.Reposatory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lap4.Controllers
{
    public class StudentController : Controller
    {
        ITIContext db = new ITIContext();
        IDeptRepo departmentRepo;// = new DepartmentRepo();
        IStudentRepo studentRepo;// = new StudentRepo();

        public StudentController(IDeptRepo _deptRepo , IStudentRepo _studentRepo)
        {
            departmentRepo = _deptRepo;
            studentRepo = _studentRepo;
            
        }
        [Authorize(Roles ="Instructor")]
        public IActionResult Index()
        {
            var model = studentRepo.GetAll(); //db.students.Include(a => a.Department).ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.deptlist = departmentRepo.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std /*,ifile*/)//model binder
        {
            //modelstate
            if (ModelState.IsValid)
            {
                studentRepo.Add(std);
                return RedirectToAction("Index");
            }
            //method upload
            //save photo name .name
            ModelState.AddModelError("", "name or age or dept is not valid");
                ViewBag.deptlist = departmentRepo.GetAll();
            //details ~/images/@model.img

            return View(std); 
            
        }
        public IActionResult Details(int? id)
        {
            if (!id.HasValue)
                return BadRequest();
            var model = studentRepo.GetById(id.Value);
            if (model == null)
                return NotFound();
            return View(model);
            //if (id == null)
            //    return BadRequest();
            //var model = db.students.Include(a => a.Department).FirstOrDefault(a => a.Id == id);
            //if (model == null)
            //    return NotFound();
            //return View("Details",model);
        }
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return BadRequest();
            var model = studentRepo.GetById(id.Value);
            if (model == null)
                return NotFound();
            ViewBag.deptlist = departmentRepo.GetAll();
            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(Student std)
        {
            db.students.Update(std);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Details2(int id)
        {
            var model = db.students.Include(a => a.Department).FirstOrDefault(a => a.Id == id);
            return PartialView(model);
        }
        public async Task<IActionResult> Add(int id, string name, int age, IFormFile stdimg)
        {
            string fileext = stdimg.FileName.Split('.').Last();
            //var fs = new FileStream($"wwwroot/images/a1.{fileext}" , FileMode.Create);
            //await stdimg.CopyToAsync(fs);
            //return Content("added");
            //fs.Dispose();
            using (var fs = new FileStream($"wwwroot/images/a1.{fileext}", FileMode.Create))
            {
                await stdimg.CopyToAsync(fs);

            }
            return Content("added");
        }
        public IActionResult CheckEmail(string Email, string Name, int Age)
        {
            var model = db.students.FirstOrDefault(a => a.Email == Email);
            if (model != null)
                return Json($"{Name}{Age}@iti.com");
            //return Json(false);
            else
                return Json(true);
        }
    }
}

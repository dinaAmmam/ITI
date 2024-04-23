using lap4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lap4.Controllers
{
    public class departmentCourseController : Controller
    {
        ITIContext db = new ITIContext();
        public IActionResult ShowCourses(int id )
        {
            var model = db.departments.Include(a=>a.courses).FirstOrDefault(a=>a.DeptId == id);
            return View(model);
        }
        public IActionResult MangeCourses(int id)
        {
            var model = db.departments.Include(a => a.courses).FirstOrDefault(a => a.DeptId == id);
            var allCourses = db.courses.ToList();
            var courseInDept = model.courses;
            var courseNotInDept = allCourses.Except(courseInDept);
            ViewBag.courseNotInDept = courseNotInDept;
            return View(model);
        }
        [HttpPost]
        public IActionResult MangeCourses(int id , List<int> coursesToRemove, List<int> coursesToAdd)
        {
            Department dept = db.departments.Include(a=>a.courses).FirstOrDefault( a => a.DeptId == id);
            foreach(var item in coursesToRemove)
            {
                Course c = db.courses.FirstOrDefault(a => a.Id == item);
                dept.courses.Remove(c);
            }
            db.SaveChanges();
            foreach (var item in coursesToAdd)
            {
                Course c = db.courses.FirstOrDefault(a => a.Id == item);
                dept.courses.Add(c);
            }
            db.SaveChanges();
            return RedirectToAction("Index" , "Department");
        }
        public IActionResult AddstudentDegree(int deptid, int crsId)
        {

            Department dept = db.departments.Include(a=>a.students).FirstOrDefault(a=>a.DeptId==deptid);
            Course course = db.courses.FirstOrDefault(a=>a.Id ==crsId);
            ViewBag.course=course;
            return View(dept);
        }

        [HttpPost]
        public IActionResult AddstudentDegree(int deptid, int crsId , Dictionary<int,int> degree)
        {
            foreach(var item in degree) 
            {
                var stdcrs= db.studentsCourses.FirstOrDefault(a=>a.StudentId==item.Key && a.CrsId==crsId);
                if (stdcrs == null)
                {

                    StudentCourse studentCourse = new StudentCourse() { StudentId = item.Key, CrsId = crsId, Degree = item.Value };
                    db.studentsCourses.Add(studentCourse);
                }
                else
                stdcrs.Degree= item.Value;
            }
            db.SaveChanges(); 
            return RedirectToAction("index", "department");


        }
    }
}

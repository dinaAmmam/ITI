using lap2.DTO;
using lap2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lap2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentController : ControllerBase
    {
        ITIDbContext db;
        public studentController(ITIDbContext db)
        {
            this.db = db;
        }


        [HttpGet]
        public ActionResult getall()
        {
            List<Student> sts = db.Students.Include(n => n.dept).ToList();
            List<studentdepartmentDTO> stsdto = new List<studentdepartmentDTO>();
            foreach (var item in sts)
            {
                studentdepartmentDTO d = new studentdepartmentDTO()
                {
                    studentID = item.id,
                    fullname = item.name + " " + item.lname,
                    age = item.age,
                    supervisorName = item.dept.supervisorName,
                    departmentName = item.dept.name
                };
                stsdto.Add(d);
            }

            return Ok(stsdto);
        }

        [HttpGet("{id}")]
        public ActionResult getbyid(int id)
        {
            Student s = db.Students.Include(n => n.dept).Where(n => n.id == id).FirstOrDefault();
            studentdepartmentDTO st = new studentdepartmentDTO()
            {
                studentID = s.id,
                fullname = s.name + " " + s.lname,
                age = s.age,
                //supervisorName = s.dept.supervisorName,
                departmentName = s.dept.name
            };

            return Ok(st);
        }


        //add
        //[HttpPost]
        //public ActionResult add(studentdepartmentDTO s)
        //{
        //    Student st = new Student();
        //    st.name = s.fullname;
        //    st.age = s.age;
        //    st.did = s.studentID;
        //    st.dept.supervisorName = s.supervisorName;

        //    db.Students.Add(st);
        //    db.SaveChanges();
        //    return Ok();

        //}


        [HttpPost]
        public ActionResult Add(studentdepartmentDTO s)
        {

            Student st = new Student();


            st.name = s.fullname;
            st.age = s.age;
            st.did = s.studentID;

            Department department = db.Departments.FirstOrDefault(d => d.id == s.studentID);
            if (department == null)
            {
                department = new Department();
                department.supervisorName = s.supervisorName;
                department.name = s.departmentName;

                db.Departments.Add(department);
            }

            st.dept = department;

            db.Students.Add(st);
            db.SaveChanges();

            return Ok();
        }





    }
}

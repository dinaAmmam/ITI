using Api_lap1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_lap1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        testDBContext db;
        public CourseController(testDBContext db)
        {
            this.db = db;
            
        }
        [HttpGet]
        public ActionResult<List<Course>> Get()
        {
            if (db.Courses.Count() > 0)
            {
                return Ok(db.Courses.ToList());
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public ActionResult delete(int id)
        {
            Course crs = db.Courses.Find(id);
            if (crs == null) return NotFound();
            else
            {
                db.Courses.Remove(crs);
                db.SaveChanges();
                return Ok(db.Courses.ToList());
            }
        }

        [HttpPut("{id}")]
        public ActionResult edit(Course crs, int id)
        {
            if (crs == null) return NotFound();
            if (crs.ID != id) return BadRequest();
            db.Entry(crs).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return NoContent();
        }

        [HttpPost]
        public ActionResult add(Course crs)
        {
            if (crs == null) return BadRequest();
            else
            {
                db.Courses.Add(crs);
                db.SaveChanges();
                return Created();
                // return CreatedAtAction("getbyname", new { name = s.name }, s);
            }
        }
        [HttpGet("{id:int}")]
        public ActionResult<Course> getById(int id)
        {
            Course crs = db.Courses.Find(id);
            if (crs == null)
                return NotFound();
            else
                return crs;
        }

        //[HttpGet("{name:alpha}")]
        //public IActionResult getCourseByName(string name)
        //{
        //    if (name == null)
        //        return NotFound();
        //    else
        //        return db.Courses.FirstOrDefault(n => n.Crs_name == name);

        //}

        [HttpGet("{name:alpha}")]
        public IActionResult GetCourseByName(string name)
        {
            if (name == null)
            {
                return NotFound();
            }
            else
            {
                var course = db.Courses.FirstOrDefault(n => n.Crs_name == name);

                if (course != null)
                {
                    return Ok(course);
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}

using APID2.DTO;
using lap2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lap2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class deptController : ControllerBase
    {
        ITIDbContext db;
        public deptController(ITIDbContext db)
        {
            this.db = db;
        }
        [HttpGet("{id}")]
        public ActionResult getbyid(int id)
        {
            Department d = db.Departments.Include(o => o.students).Where(n => n.id == id).FirstOrDefault();

            deptstudentsDTO deptdto = new deptstudentsDTO()
            {
                name = d.name,
                loc = d.loc,
                supervisorName = d.supervisorName,
                studentNames = d.students.Select(n => n.name).ToList()
            };

            return Ok(deptdto);
        }
    }
}

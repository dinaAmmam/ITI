using Microsoft.EntityFrameworkCore;
namespace lap2.Models
{
    public class ITIDbContext:DbContext
    {
        public ITIDbContext(DbContextOptions o):base(o)
        {
            
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}

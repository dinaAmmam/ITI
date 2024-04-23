using Microsoft.EntityFrameworkCore;

namespace lap3._2.Models
{
    public class ITIContext:DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ODUF6AM;Initial Catalog=temp3;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace lap4.Models
{
    public class ITIContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<StudentCourse> studentsCourses { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ODUF6AM;Initial Catalog=Newdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(c => new { c.StudentId , c.CrsId });
            base.OnModelCreating(modelBuilder);
        }
    }
}

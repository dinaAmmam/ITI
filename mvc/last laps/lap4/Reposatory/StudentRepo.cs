using lap4.Models;
using Microsoft.EntityFrameworkCore;

namespace lap4.Reposatory
{
    public interface IStudentRepo
    {
        List<Student> GetAll();
        Student GetById(int id);
        void Add(Student student);
        void Update(Student student);
        void Delete(int id);
    }
    public class StudentRepo:IStudentRepo
    {
        ITIContext db = new ITIContext();
        public List <Student> GetAll() 
        {
            return db.students.Include(s => s.Department).ToList();
        }
        public Student GetById(int id) 
        { 
            return db.students.Include(s => s.Department).SingleOrDefault(x => x.Id == id);
        }
        public void Add(Student student)
        { 
            db.students.Add(student);
            db.SaveChanges();
        }
        public void Update(Student student) 
        { 
            db.students.Update(student);
            db.SaveChanges();
            //return student.Id;
        }
        public void Delete(int id)
        {
            var s = db.students.FirstOrDefault(a => a.Id == id);
            db.students.Remove(s);
            db.SaveChanges();
        }
    }
}

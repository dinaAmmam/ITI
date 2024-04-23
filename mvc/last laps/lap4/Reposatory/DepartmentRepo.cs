using lap4.Models;

namespace lap4.Reposatory
{
    public interface IDeptRepo
    {
        List<Department> GetAll();
        Department GetById(int id);
        void Add(Department d);
        void Update(Department d);
        void Delete(int id);

    }
    public class DepartmentRepo:IDeptRepo
    {
        ITIContext db = new ITIContext();
        public List<Department> GetAll()
        {
            Console.WriteLine("departmentlist required");
            return db.departments.Where(a=>a.Status == true).ToList();
        }
        public Department GetById(int id) 
        { 
            return db.departments.SingleOrDefault(a=>a.DeptId == id); 
        }
        public void Add(Department department)
        {
            db.departments.Add(department);
            db.SaveChanges();
        }
        public void Update(Department department)
        { 
            db.departments.Update(department);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var dept = GetById(id);
            dept.Status = false;
            //db.departments.Remove(dept);
            db.SaveChanges();
        }
    }
}

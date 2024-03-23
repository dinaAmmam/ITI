using Microsoft.AspNetCore.Mvc;

using lap2._2.Models;

namespace lap2._2.Controllers;

public class DepartmentController : Controller
{
    //public IActionResult Index()
    //{
    //    return View();
    //}
    /*public IActionResult Display()
    {
        string name = "dina";
        int id = 1;
        ViewData[name] = name;
    
    }*/
    public IActionResult Index()
    {
        List<Department> departments = new List<Department>
        {
            new Department {DeptId = 10 , DeptName = "os" },
            new Department{ DeptId = 20 , DeptName = "is" },
            new Department {DeptId = 30 , DeptName = "it" }
        };

        return View(departments);
    }

    public IActionResult Details()
    {
        Department department1 = new Department { DeptId=1, DeptName="it"};
        ViewData["dept"] = department1;
        return View();

    }
    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Add(Department dept)
    {
        //return Content("add");
        //Department dept = new Department() { DeptId = id , DeptName = name};
        return Json(dept);
    }




    public IActionResult Show()
    {
        return Json(new { x = 20, y = 30 });
        
    }
}

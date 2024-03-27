using Microsoft.AspNetCore.Mvc;

namespace lap3._1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Add(int id, string name, int age, IFormFile stdimg)
        {
            string fileext = stdimg.FileName.Split('.').Last();
            //var fs = new FileStream($"wwwroot/images/a1.{fileext}" , FileMode.Create);
            //await stdimg.CopyToAsync(fs);
            //return Content("added");
            //fs.Dispose();
            using( var fs = new FileStream($"wwwroot/images/a1.{fileext}", FileMode.Create))
            {
                await stdimg.CopyToAsync(fs);

            }
            return Content("added");

        }
    }
}

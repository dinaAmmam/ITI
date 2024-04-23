using lap4.Models;
using lap4.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace lap4.Controllers
{
    //[Authorize]
    public class AccountController : Controller
    {
        //[AllowAnonymous]
        public IActionResult Register()
        {
            return View(); //show form user data (name , email , password , age)
        }
        //[AllowAnonymous]
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User() { Name = model.Name, Age=model.Age , Password = model.Password , Email = model.Email };
                ITIContext db = new ITIContext();
                db.users.Add(user);
                db.SaveChanges();
                var role = db.roles.FirstOrDefault(a => a.Name == "Students");
                user.Roles.Add(role);
                db.SaveChanges();
                return RedirectToAction("login");

            }
            // user in database
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Login() 
        { 

            return View(); // show form ( email , password )
        }
        //[AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model) 
        {
            ITIContext db = new ITIContext();
            var res = db.users.Include(a=>a.Roles).FirstOrDefault(a=>a.Email == model.Email && a.Password == model.Password);
            if (res == null)
            {
                ModelState.AddModelError("", "username and password invalid");
                return View(model);
            }
            //check in db
            Claim c1 = new Claim(ClaimTypes.Name , res.Name);
            Claim c2 = new Claim (ClaimTypes.Email , res.Email);
            List<Claim> Roleclaims = new List<Claim>();
            foreach(var item in res.Roles)
            {
                Roleclaims.Add(new Claim(ClaimTypes.Role , item.Name));
            }

            ClaimsIdentity ci = new ClaimsIdentity("Cookies");
            ci.AddClaim(c1);
            ci.AddClaim(c2);
            foreach(var item in Roleclaims)
            {
                ci.AddClaim(item);
            }


            ClaimsPrincipal cp = new ClaimsPrincipal();
            cp.AddIdentity(ci);
            //
            await HttpContext.SignInAsync(cp);
            //encrypt , add to cookies
            return RedirectToAction("Index" , "Home");
        }
        [Authorize]
        public async Task<IActionResult> LogOut() 
        {
           await HttpContext.SignOutAsync();
            return RedirectToAction("Index" , "Home");
        }
    }
}

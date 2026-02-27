using MVC_Application.Filters;
using System;
using System.Web.Mvc;

namespace MVC_Application.Controllers
{
    public class AccountController : Controller
    {
        
        // GET: Login (No Auth Filter Here)
        
        public ActionResult Login()
        {
            return View();
        }

        
        // POST: Login
  
        [HttpPost]
        [MyException]   // Exception filter only here
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                Session["User"] = username;
                return RedirectToAction("Register");
            }

            // Trigger exception for wrong login
            throw new Exception("Invalid Username or Password!");
        }

       
        // GET: Register
     
        [AuthFilter]
        [MyActionFilter]
        [MyResultFilter]
        [MyException]
        public ActionResult Register()
        {
            return View();
        }

        
        // POST: Register
        
        [HttpPost]
        [AuthFilter]
        [MyActionFilter]
        [MyResultFilter]
        [MyException]
        public ActionResult Register(object model)
        {
            TempData["Success"] = "Registration Successful!";
            return RedirectToAction("Register");
        }

        // --------------------
        // Logout
        // --------------------
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
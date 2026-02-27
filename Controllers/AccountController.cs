using MVC_Application.Filters;
using System;
using System.Web.Mvc;
using Serilog;

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
        [MyException]   // execption filter
        public ActionResult Login(string username, string password)
        {
            string userIP = Request.UserHostAddress;

            // Log login attempt
            Log.Information("Login attempt for Username: {Username} from IP: {IP}",
                            username, userIP);

            if (username == "admin" && password == "1234")
            {
                Session["User"] = username;

                Log.Information("Login SUCCESS for Username: {Username}", username);

                return RedirectToAction("Register");
            }

            // If login fails
            Log.Warning("Login FAILED for Username: {Username} from IP: {IP}",
                        username, userIP);

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
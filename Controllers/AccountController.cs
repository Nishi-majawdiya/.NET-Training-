using System.Web.Mvc;
using MVC_Application.Models;

namespace MVC_Application.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Account/Register
        [HttpPost]
        public ActionResult Register(UserRegistration model)
        {
            if (ModelState.IsValid)
            {
                // Normally you would save data to database here

                TempData["Success"] = "Registration Successful!";
                return RedirectToAction("Register"); // Page refresh
            }

            return View(model); // Show validation errors
        }
    }
}
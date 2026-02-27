using System.Web.Mvc;
using System.Text;

namespace MVCProject.Areas.Admin.Controllers
{
    public class DemoController : Controller
    {
        // 1️⃣ ViewResult
        public ActionResult ShowView()
        {
            return View();
        }

        // 2️⃣ ContentResult
        public ActionResult ShowContent()
        {
            return Content("Hello from Admin Area - ContentResult");
        }

        // 3️⃣ RedirectToActionResult
        public ActionResult GoToView()
        {
            return RedirectToAction("ShowView");
        }

        // 4️⃣ RedirectResult
        public ActionResult GoToGoogle()
        {
            return Redirect("https://www.google.com");
        }

        // 5️⃣ JsonResult
        public ActionResult GetJson()
        {
            return Json(
                new { Name = "Nishi", Area = "Admin" },
                JsonRequestBehavior.AllowGet
            );
        }

        // 6️⃣ FileResult
        public ActionResult DownloadFile()
        {
            byte[] fileBytes =  Encoding.UTF8.GetBytes("This is a sample file from Admin Area.");
            return File(fileBytes, "text/plain", "SampleFile.txt");
        }

        // 7️⃣ HttpStatusCodeResult
        public ActionResult NotFoundPage()
        {
            return HttpNotFound("Page Not Found in Admin Area");
        }

        // 8️⃣ EmptyResult
        public ActionResult Empty()
        {
            return new EmptyResult();
        }
    }
}
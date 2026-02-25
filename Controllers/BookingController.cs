using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Application.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string From, string To, DateTime Date)
        {
            ViewBag.From = From;
            ViewBag.To = To;
            ViewBag.Date = Date;

            return View("SearchResult");
        }
    }
    }

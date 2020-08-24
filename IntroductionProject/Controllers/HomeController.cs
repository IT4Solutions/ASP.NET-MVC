using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroductionProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MyName = "Muhammad Hammad";
            ViewData["Your Name"] = "Raouf Yasin";
            TempData["NY"] = "Yes I am here";
            return View();
        }

        public ActionResult Aboutus()
        {
            TempData["NYY"] = "Yes I am here";
            return RedirectToAction("Index", "Account");
        }

        public ActionResult Contactus()
        {
            return View();
        }
    }
}
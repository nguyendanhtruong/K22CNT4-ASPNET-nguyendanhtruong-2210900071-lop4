using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lad01._1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.message = "chào bn tôi là trường. ";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "trương about.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "trường a.";

            return View();
        }
    }
}
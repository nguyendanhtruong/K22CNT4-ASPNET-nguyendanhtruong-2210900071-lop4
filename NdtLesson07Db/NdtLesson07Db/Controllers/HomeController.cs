using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NdtLesson07Db.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult NdtIndex()
        {
            return View();
        }

        public ActionResult NdtAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NdtContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using NdtK22CNT4Lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NdtK22CNT4Lesson10.Controllers
{
    public class NdtHomeController : Controller
    {
        public ActionResult NdtIndex()
        {
            // kiểm tra session
            if (Session["NdtAccount"] != null)
            {
                var ndtAccount = Session["NdtAccount"] as NdtAccount;
                ViewBag.FullName = ndtAccount.NdtFullName;
            }
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
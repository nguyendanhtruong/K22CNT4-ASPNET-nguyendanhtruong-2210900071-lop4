using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Ndt_lesson02.Controllers
{
    /// <summary>
    /// name:Nguyễn Danh Trường 
    /// class:CNTT4
    /// </summary>
    public class NdtController : Controller
    {
        // GET: Ndt
        public ActionResult Index()
        {
            //chuyền dữ liệu từ cotron lo lên view
            ViewBag.fullName = "Nguyễn Danh Trường";
            ViewData["birthday"] = "05/02/2004";
            TempData["phone"] = "0797475264";
            return View();
        }

        public ActionResult Details()
        {
            string ndtStr = "";
           
            ndtStr += "<h3>họ và tên :Nguyễn Danh TRường </h3>";
            ndtStr += "<p> masinvie:2210900071";
            ndtStr += "<p> email:truong626215@gmail.com";
            ViewBag.Details = ndtStr;

            return View("chitiet");
        }
        public ActionResult NgonNguRazor()
        {

            string[] names = { "Nguyễn Danh A", "Đinh Công C", "Ngô Văn D", "Bùi Trà E" };
            ViewBag.names = names;
            return View();
        }
        //htmlhelper
        //get :Ndt/AddNewStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            // lay du lieu tren form
            string fullname = form["fullname"];
            string masv = form["masv"];
            string taikhoan = form["taikhoan"];
            string matkhau= form["matkhau"];
            string ndtStr = "<h3>" + fullname + "</h3>";
            ndtStr += "<p>" + masv;
            ndtStr += "<p>" + taikhoan;
            ndtStr += "<p>" + matkhau;

            ViewBag.info = ndtStr;
            return View("ketqua");
        }

    }
}
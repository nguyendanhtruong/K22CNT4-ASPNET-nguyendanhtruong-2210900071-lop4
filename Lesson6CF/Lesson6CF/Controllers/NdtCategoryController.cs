using Lesson6CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson6CF.Controllers
{
    public class NdtCategoryController : Controller
    {
        private static NdtBookStore ndtDb;
        public NdtCategoryController()
        {
            ndtDb = new NdtBookStore();

        }
        // GET: NdtCategory
        public ActionResult NdtIndex()
        {
            /*
             * khởi tạo DbContext
             * EF sẽ tìm thông tin kết nối 
             * */
           // NdtBookStore ndtDb = new NdtBookStore();
            var ndtCategoris = ndtDb.NdtCategories.ToList();
            return View(ndtCategoris);
        }
        public ActionResult NdtCreate()
        {
            var ndtCategory = new NdtCategory();
            return View(ndtCategory);
        }
        [HttpPost]
        public ActionResult NdtCreate(NdtCategory ndtCategory)
        {
            ndtDb.NdtCategories.Add(ndtCategory);
            ndtDb.SaveChanges();
            return RedirectToAction("NdtIndex");
        }
    }
}
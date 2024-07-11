using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NguyenDanhTruong_2210900071.Models;

namespace NguyenDanhTruong_2210900071.Controllers
{
    public class NDT_TACGIAController : Controller
    {
        private Nguyễn_Danh_Trường__2210900071Entities db = new Nguyễn_Danh_Trường__2210900071Entities();

        // GET: NDT_TACGIA
        public ActionResult NdtIndex()
        {
            return View(db.NDT_TACGIA.ToList());
        }

        // GET: NDT_TACGIA/Details/5
        public ActionResult NdtDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NDT_TACGIA nDT_TACGIA = db.NDT_TACGIA.Find(id);
            if (nDT_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nDT_TACGIA);
        }

        // GET: NDT_TACGIA/Create
        public ActionResult NdtCreate()
        {
            return View();
        }

        // POST: NDT_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NdtCreate([Bind(Include = "Ndt_MaTG,Ndt_TenTacGia")] NDT_TACGIA nDT_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.NDT_TACGIA.Add(nDT_TACGIA);
                db.SaveChanges();
                return RedirectToAction("NdtIndex");
            }

            return View(nDT_TACGIA);
        }

        // GET: NDT_TACGIA/Edit/5
        public ActionResult NdtEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NDT_TACGIA nDT_TACGIA = db.NDT_TACGIA.Find(id);
            if (nDT_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nDT_TACGIA);
        }

        // POST: NDT_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NdtEdit([Bind(Include = "Ndt_MaTG,Ndt_TenTacGia")] NDT_TACGIA nDT_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nDT_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NdtIndex");
            }
            return View(nDT_TACGIA);
        }

        // GET: NDT_TACGIA/Delete/5
        public ActionResult NdtDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NDT_TACGIA nDT_TACGIA = db.NDT_TACGIA.Find(id);
            if (nDT_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nDT_TACGIA);
        }

        // POST: NDT_TACGIA/Delete/5
        [HttpPost, ActionName("NdtDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NdtDeleteConfirmed(string id)
        {
            NDT_TACGIA nDT_TACGIA = db.NDT_TACGIA.Find(id);
            db.NDT_TACGIA.Remove(nDT_TACGIA);
            db.SaveChanges();
            return RedirectToAction("NdtIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

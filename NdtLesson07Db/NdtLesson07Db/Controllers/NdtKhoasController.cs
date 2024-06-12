using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NdtLesson07Db.Models;

namespace NdtLesson07Db.Controllers
{
    public class NdtKhoasController : Controller
    {
        private NdtK22CNTT4Lesson07DbEntities db = new NdtK22CNTT4Lesson07DbEntities();

        // GET: NdtKhoas
        public ActionResult NdtIndex()
        {
            return View(db.NdtKhoas.ToList());
        }

        // GET: NdtKhoas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtKhoa ndtKhoa = db.NdtKhoas.Find(id);
            if (ndtKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ndtKhoa);
        }

        // GET: NdtKhoas/Create
        public ActionResult NdtCreate()
        {
            return View();
        }

        // POST: NdtKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NdtCreate([Bind(Include = "NdtMaKH,NdtTenKH,NdtTrangThai")] NdtKhoa ndtKhoa)
        {
            if (ModelState.IsValid)
            {
                db.NdtKhoas.Add(ndtKhoa);
                db.SaveChanges();
                return RedirectToAction("NdtIndex");
            }

            return View(ndtKhoa);
        }

        // GET: NdtKhoas/Edit/5
        public ActionResult NdtEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtKhoa ndtKhoa = db.NdtKhoas.Find(id);
            if (ndtKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ndtKhoa);
        }

        // POST: NdtKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NdtEdit([Bind(Include = "NdtMaKH,NdtTenKH,NdtTrangThai")] NdtKhoa ndtKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ndtKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NdtIndex");
            }
            return View(ndtKhoa);
        }

        // GET: NdtKhoas/Delete/5
        public ActionResult NdtDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtKhoa ndtKhoa = db.NdtKhoas.Find(id);
            if (ndtKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ndtKhoa);
        }

        // POST: NdtKhoas/Delete/5
        [HttpPost, ActionName("NdtDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NdtKhoa ndtKhoa = db.NdtKhoas.Find(id);
            db.NdtKhoas.Remove(ndtKhoa);
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

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
    public class NDT_SACHController : Controller
    {
        private Nguyễn_Danh_Trường__2210900071Entities db = new Nguyễn_Danh_Trường__2210900071Entities();

        // GET: NDT_SACH
        public ActionResult NdtIndex()
        {
            var nDT_SACH = db.NDT_SACH.Include(n => n.NDT_TACGIA);
            return View(nDT_SACH.ToList());
        }
        
        // GET: NDT_SACH/Details/5
        public ActionResult NdtDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NDT_SACH nDT_SACH = db.NDT_SACH.Find(id);
            if (nDT_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nDT_SACH);
        }

        // GET: NDT_SACH/Create
        public ActionResult NdtCreate()
        {
            ViewBag.Ndt_MaTG = new SelectList(db.NDT_TACGIA, "Ndt_MaTG", "Ndt_TenTacGia");
            return View();
        }

        // POST: NDT_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NdtCreate([Bind(Include = "Ndt_MaSach,Ndt_TenSach,Ndt_SoTrang,Ndt_NamXB,Ndt_MaTG,Ndt_TrangThai")] NDT_SACH nDT_SACH)
        {
            if (ModelState.IsValid)
            {
                db.NDT_SACH.Add(nDT_SACH);
                db.SaveChanges();
                return RedirectToAction("NdtIndex");
            }

            ViewBag.Ndt_MaTG = new SelectList(db.NDT_TACGIA, "Ndt_MaTG", "Ndt_TenTacGia", nDT_SACH.Ndt_MaTG);
            return View(nDT_SACH);
        }

        // GET: NDT_SACH/Edit/5
        public ActionResult NdtEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NDT_SACH nDT_SACH = db.NDT_SACH.Find(id);
            if (nDT_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Ndt_MaTG = new SelectList(db.NDT_TACGIA, "Ndt_MaTG", "Ndt_TenTacGia", nDT_SACH.Ndt_MaTG);
            return View(nDT_SACH);
        }

        // POST: NDT_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NdtEdit([Bind(Include = "Ndt_MaSach,Ndt_TenSach,Ndt_SoTrang,Ndt_NamXB,Ndt_MaTG,Ndt_TrangThai")] NDT_SACH nDT_SACH)
        {
            
            if (ModelState.IsValid)
            {
                db.Entry(nDT_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NdtIndex");
            }
            ViewBag.Ndt_MaTG = new SelectList(db.NDT_TACGIA, "Ndt_MaTG", "Ndt_TenTacGia", nDT_SACH.Ndt_MaTG);
            return View(nDT_SACH);
        }

        // GET: NDT_SACH/Delete/5
        public ActionResult NdtDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NDT_SACH nDT_SACH = db.NDT_SACH.Find(id);
            if (nDT_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nDT_SACH);
        }

        // POST: NDT_SACH/Delete/5
        [HttpPost, ActionName("NdtDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NDT_SACH nDT_SACH = db.NDT_SACH.Find(id);
            db.NDT_SACH.Remove(nDT_SACH);
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

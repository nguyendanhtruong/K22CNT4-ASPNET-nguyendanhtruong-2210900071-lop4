using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NdtK22CNT4Lesson11_2210900071.Models;

namespace NdtK22CNT4Lesson11_2210900071.Controllers
{
    public class NdtProductsController : Controller
    {
        private NdtK22CNT4Lesson11DbEntities db = new NdtK22CNT4Lesson11DbEntities();

        // GET: NdtProducts
        public ActionResult NdtIndex()
        {
            return View(db.NdtProducts.ToList());
        }

        // GET: NdtProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtProduct ndtProduct = db.NdtProducts.Find(id);
            if (ndtProduct == null)
            {
                return HttpNotFound();
            }
            return View(ndtProduct);
        }

        // GET: NdtProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NdtProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ndtid2210900071,NdtProName,NdtQty,NdtPrice,NdtCateId,NdtActive")] NdtProduct ndtProduct)
        {
            if (ModelState.IsValid)
            {
                db.NdtProducts.Add(ndtProduct);
                db.SaveChanges();
                return RedirectToAction("NdtIndex");
            }

            return View(ndtProduct);
        }

        // GET: NdtProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtProduct ndtProduct = db.NdtProducts.Find(id);
            if (ndtProduct == null)
            {
                return HttpNotFound();
            }
            return View(ndtProduct);
        }

        // POST: NdtProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ndtid2210900071,NdtProName,NdtQty,NdtPrice,NdtCateId,NdtActive")] NdtProduct ndtProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ndtProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NdtIndex");
            }
            return View(ndtProduct);
        }

        // GET: NdtProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtProduct ndtProduct = db.NdtProducts.Find(id);
            if (ndtProduct == null)
            {
                return HttpNotFound();
            }
            return View(ndtProduct);
        }

        // POST: NdtProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NdtProduct ndtProduct = db.NdtProducts.Find(id);
            db.NdtProducts.Remove(ndtProduct);
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

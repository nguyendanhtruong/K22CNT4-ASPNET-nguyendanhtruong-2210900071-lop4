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
    public class NdtCategoriesController : Controller
    {
        private NdtK22CNT4Lesson11DbEntities db = new NdtK22CNT4Lesson11DbEntities();

        // GET: NdtCategories
        public ActionResult NdtIndex()
        {
            return View(db.NdtCategories.ToList());
        }

        // GET: NdtCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtCategory ndtCategory = db.NdtCategories.Find(id);
            if (ndtCategory == null)
            {
                return HttpNotFound();
            }
            return View(ndtCategory);
        }

        // GET: NdtCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NdtCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NdtID,NdtCateName,NdtStatus")] NdtCategory ndtCategory)
        {
            if (ModelState.IsValid)
            {
                db.NdtCategories.Add(ndtCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ndtCategory);
        }

        // GET: NdtCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtCategory ndtCategory = db.NdtCategories.Find(id);
            if (ndtCategory == null)
            {
                return HttpNotFound();
            }
            return View(ndtCategory);
        }

        // POST: NdtCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NdtID,NdtCateName,NdtStatus")] NdtCategory ndtCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ndtCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ndtCategory);
        }

        // GET: NdtCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtCategory ndtCategory = db.NdtCategories.Find(id);
            if (ndtCategory == null)
            {
                return HttpNotFound();
            }
            return View(ndtCategory);
        }

        // POST: NdtCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NdtCategory ndtCategory = db.NdtCategories.Find(id);
            db.NdtCategories.Remove(ndtCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
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

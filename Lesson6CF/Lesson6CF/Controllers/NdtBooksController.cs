using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lesson6CF.Models;

namespace Lesson6CF.Controllers
{
    public class NdtBooksController : Controller
    {
        private NdtBookStore db = new NdtBookStore();

        // GET: NdtBooks
        public ActionResult Index()
        {
            return View(db.NdtBooks.ToList());
        }

        // GET: NdtBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtBook ndtBook = db.NdtBooks.Find(id);
            if (ndtBook == null)
            {
                return HttpNotFound();
            }
            return View(ndtBook);
        }

        // GET: NdtBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NdtBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NdtId,NdtBookId,NdtTitle,NdtAuthor,NdtYear,NdtPulisher,NdtPicture,NDTCategoryId")] NdtBook ndtBook)
        {
            if (ModelState.IsValid)
            {
                db.NdtBooks.Add(ndtBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ndtBook);
        }

        // GET: NdtBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtBook ndtBook = db.NdtBooks.Find(id);
            if (ndtBook == null)
            {
                return HttpNotFound();
            }
            return View(ndtBook);
        }

        // POST: NdtBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NdtId,NdtBookId,NdtTitle,NdtAuthor,NdtYear,NdtPulisher,NdtPicture,NDTCategoryId")] NdtBook ndtBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ndtBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ndtBook);
        }

        // GET: NdtBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtBook ndtBook = db.NdtBooks.Find(id);
            if (ndtBook == null)
            {
                return HttpNotFound();
            }
            return View(ndtBook);
        }

        // POST: NdtBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NdtBook ndtBook = db.NdtBooks.Find(id);
            db.NdtBooks.Remove(ndtBook);
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

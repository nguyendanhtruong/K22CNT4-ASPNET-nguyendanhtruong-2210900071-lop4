using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NdtK22CNT4Lesson10.Models;

namespace NdtK22CNT4Lesson10.Controllers
{
    public class NdtAccountsController : Controller
    {
        private NdtLesson10DbEntities db = new NdtLesson10DbEntities();

        // GET: NdtAccounts
        public ActionResult Index()
        {
            return View(db.NdtAccounts.ToList());
        }

        // GET: NdtAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtAccount ndtAccount = db.NdtAccounts.Find(id);
            if (ndtAccount == null)
            {
                return HttpNotFound();
            }
            return View(ndtAccount);
        }

        // GET: NdtAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NdtAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NdtID,NdtUseName,NdtPassword,NdtFullName,NdtEmail,NdtPhone,NdtActive")] NdtAccount ndtAccount)
        {
            if (ModelState.IsValid)
            {
                db.NdtAccounts.Add(ndtAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ndtAccount);
        }

        // GET: NdtAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtAccount ndtAccount = db.NdtAccounts.Find(id);
            if (ndtAccount == null)
            {
                return HttpNotFound();
            }
            return View(ndtAccount);
        }

        // POST: NdtAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NdtID,NdtUseName,NdtPassword,NdtFullName,NdtEmail,NdtPhone,NdtActive")] NdtAccount ndtAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ndtAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ndtAccount);
        }

        // GET: NdtAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NdtAccount ndtAccount = db.NdtAccounts.Find(id);
            if (ndtAccount == null)
            {
                return HttpNotFound();
            }
            return View(ndtAccount);
        }

        // POST: NdtAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NdtAccount ndtAccount = db.NdtAccounts.Find(id);
            db.NdtAccounts.Remove(ndtAccount);
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
        public ActionResult NdtLogin()
        {
            var ndtModel = new NdtAccount();
            return View(ndtModel);
        }
        [HttpPost]
        public ActionResult NdtLogin(NdtAccount ndtAccount)
        {
            var ndtCheck = db.NdtAccounts.Where(x => x.NdtUseName.Equals(ndtAccount.NdtUseName) && x.NdtPassword.Equals(ndtAccount.NdtPassword)).FirstOrDefault();
             if (ndtCheck !=null)
            {
                Session["NdtAccount"] = ndtCheck;
                return Redirect("/");
            }

            return View(ndtAccount);
        }
    }
}

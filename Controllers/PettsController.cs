using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mis42p2rd484215.DAL;
using mis42p2rd484215.Models;

namespace mis42p2rd484215.Controllers
{
    public class PettsController : Controller
    {
        private SD2Context db = new SD2Context();

        // GET: Petts
        public ActionResult Index()
        {
            return View(db.Petts.ToList());
        }

        // GET: Petts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Petts petts = db.Petts.Find(id);
            if (petts == null)
            {
                return HttpNotFound();
            }
            return View(petts);
        }

        // GET: Petts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Petts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pettsID,petName,petType,ownerLastName,ownerFirstName,email,phone,patientSince")] Petts petts)
        {
            if (ModelState.IsValid)
            {
                db.Petts.Add(petts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(petts);
        }

        // GET: Petts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Petts petts = db.Petts.Find(id);
            if (petts == null)
            {
                return HttpNotFound();
            }
            return View(petts);
        }

        // POST: Petts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pettsID,petName,petType,ownerLastName,ownerFirstName,email,phone,patientSince")] Petts petts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(petts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(petts);
        }

        // GET: Petts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Petts petts = db.Petts.Find(id);
            if (petts == null)
            {
                return HttpNotFound();
            }
            return View(petts);
        }

        // POST: Petts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Petts petts = db.Petts.Find(id);
            db.Petts.Remove(petts);
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

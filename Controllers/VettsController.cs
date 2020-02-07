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
    public class VettsController : Controller
    {
        private SD2Context db = new SD2Context();

        // GET: Vetts
        public ActionResult Index()
        {
            return View(db.Vett.ToList());
        }

        // GET: Vetts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vett vett = db.Vett.Find(id);
            if (vett == null)
            {
                return HttpNotFound();
            }
            return View(vett);
        }

        // GET: Vetts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vetts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vettID,vetLastName,vetFirstName,email,phone")] Vett vett)
        {
            if (ModelState.IsValid)
            {
                db.Vett.Add(vett);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vett);
        }

        // GET: Vetts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vett vett = db.Vett.Find(id);
            if (vett == null)
            {
                return HttpNotFound();
            }
            return View(vett);
        }

        // POST: Vetts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vettID,vetLastName,vetFirstName,email,phone")] Vett vett)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vett).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vett);
        }

        // GET: Vetts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vett vett = db.Vett.Find(id);
            if (vett == null)
            {
                return HttpNotFound();
            }
            return View(vett);
        }

        // POST: Vetts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vett vett = db.Vett.Find(id);
            db.Vett.Remove(vett);
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

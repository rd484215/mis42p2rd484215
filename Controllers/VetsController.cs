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
    public class VetsController : Controller
    {
        private SD2Context db = new SD2Context();

        // GET: Vets
        public ActionResult Index()
        {
            var vet = db.Vet.Include(v => v.Pets);
            return View(vet.ToList());
        }

        // GET: Vets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vet vet = db.Vet.Find(id);
            if (vet == null)
            {
                return HttpNotFound();
            }
            return View(vet);
        }

        // GET: Vets/Create
        public ActionResult Create()
        {
            ViewBag.petsID = new SelectList(db.Pets, "petsID", "petName");
            return View();
        }

        // POST: Vets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vetID,vetLastName,vetFirstName,email,phone,petsID")] Vet vet)
        {
            if (ModelState.IsValid)
            {
                db.Vet.Add(vet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.petsID = new SelectList(db.Pets, "petsID", "petName", vet.petsID);
            return View(vet);
        }

        // GET: Vets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vet vet = db.Vet.Find(id);
            if (vet == null)
            {
                return HttpNotFound();
            }
            ViewBag.petsID = new SelectList(db.Pets, "petsID", "petName", vet.petsID);
            return View(vet);
        }

        // POST: Vets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vetID,vetLastName,vetFirstName,email,phone,petsID")] Vet vet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.petsID = new SelectList(db.Pets, "petsID", "petName", vet.petsID);
            return View(vet);
        }

        // GET: Vets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vet vet = db.Vet.Find(id);
            if (vet == null)
            {
                return HttpNotFound();
            }
            return View(vet);
        }

        // POST: Vets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vet vet = db.Vet.Find(id);
            db.Vet.Remove(vet);
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

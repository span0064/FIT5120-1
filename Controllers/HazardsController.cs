﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fit5120.Models;

namespace fit5120.Controllers
{
    public class HazardsController : Controller
    {
        private MOdelContainer db = new MOdelContainer();

        // GET: Hazards
        public ActionResult Index()
        {
            return View(db.Hazards.ToList());
        }

        
        

        // GET: Hazards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hazard hazard = db.Hazards.Find(id);
            if (hazard == null)
            {
                return HttpNotFound();
            }
            return View(hazard);
        }

        // GET: Hazards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hazards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,HazardName,Details")] Hazard hazard)
        {
            if (ModelState.IsValid)
            {
                db.Hazards.Add(hazard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hazard);
        }

        // GET: Hazards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hazard hazard = db.Hazards.Find(id);
            if (hazard == null)
            {
                return HttpNotFound();
            }
            return View(hazard);
        }

        // POST: Hazards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,HazardName,Details")] Hazard hazard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hazard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hazard);
        }

        // GET: Hazards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hazard hazard = db.Hazards.Find(id);
            if (hazard == null)
            {
                return HttpNotFound();
            }
            return View(hazard);
        }

        // POST: Hazards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hazard hazard = db.Hazards.Find(id);
            db.Hazards.Remove(hazard);
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

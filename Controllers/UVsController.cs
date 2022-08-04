using System;
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
    public class UVsController : Controller
    {
        private MOdelContainer db = new MOdelContainer();

        // GET: UVs
        public ActionResult Index()
        {
            var trainingExercises = db.UVs.Max(i => i.UV_Value);
            var forecast = db.UVs.Max(j => j.Forecast_value);
            ViewBag.data = trainingExercises;
            ViewBag.data1 = forecast;
            return View();
        }

        // GET: UVs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UV uV = db.UVs.Find(id);
            if (uV == null)
            {
                return HttpNotFound();
            }
            return View(uV);
        }

        // GET: UVs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UVs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UV_Value,Forecast_value")] UV uV)
        {
            if (ModelState.IsValid)
            {
                db.UVs.Add(uV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uV);
        }

        // GET: UVs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UV uV = db.UVs.Find(id);
            if (uV == null)
            {
                return HttpNotFound();
            }
            return View(uV);
        }

        // POST: UVs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UV_Value,Forecast_value")] UV uV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uV);
        }

        // GET: UVs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UV uV = db.UVs.Find(id);
            if (uV == null)
            {
                return HttpNotFound();
            }
            return View(uV);
        }

        // POST: UVs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UV uV = db.UVs.Find(id);
            db.UVs.Remove(uV);
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

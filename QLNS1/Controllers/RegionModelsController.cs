using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLNS1.Models;

namespace QLNS1.Controllers
{
    public class RegionModelsController : Controller
    {
        private QLNSdatabase db = new QLNSdatabase();

        // GET: RegionModels
        public ActionResult Index()
        {
            return View(db.Regions.ToList());
        }

        // GET: RegionModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegionModel regionModel = db.Regions.Find(id);
            if (regionModel == null)
            {
                return HttpNotFound();
            }
            return View(regionModel);
        }

        // GET: RegionModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegionModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RegionID,RegionName,IsActive,DateCreated,UserCreate,DateLastUpdate,UserLastUpdate")] RegionModel regionModel)
        {
            if (ModelState.IsValid)
            {
                db.Regions.Add(regionModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(regionModel);
        }

        // GET: RegionModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegionModel regionModel = db.Regions.Find(id);
            if (regionModel == null)
            {
                return HttpNotFound();
            }
            return View(regionModel);
        }

        // POST: RegionModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RegionID,RegionName,IsActive,DateCreated,UserCreate,DateLastUpdate,UserLastUpdate")] RegionModel regionModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regionModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regionModel);
        }

        // GET: RegionModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegionModel regionModel = db.Regions.Find(id);
            if (regionModel == null)
            {
                return HttpNotFound();
            }
            return View(regionModel);
        }

        // POST: RegionModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegionModel regionModel = db.Regions.Find(id);
            db.Regions.Remove(regionModel);
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

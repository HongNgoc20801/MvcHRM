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
    public class NationModelsController : Controller
    {
        private QLNSdatabase db = new QLNSdatabase();

        // GET: NationModels
        public ActionResult Index()
        {
            return View(db.Nations.ToList());
        }

        // GET: NationModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NationModel nationModel = db.Nations.Find(id);
            if (nationModel == null)
            {
                return HttpNotFound();
            }
            return View(nationModel);
        }

        // GET: NationModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NationModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NationID,NationName,IsActive,DateCreated,UserCreate,DateLastUpdate,UserLastUpdate")] NationModel nationModel)
        {
            if (ModelState.IsValid)
            {
                db.Nations.Add(nationModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nationModel);
        }

        // GET: NationModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NationModel nationModel = db.Nations.Find(id);
            if (nationModel == null)
            {
                return HttpNotFound();
            }
            return View(nationModel);
        }

        // POST: NationModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NationID,NationName,IsActive,DateCreated,UserCreate,DateLastUpdate,UserLastUpdate")] NationModel nationModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nationModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nationModel);
        }

        // GET: NationModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NationModel nationModel = db.Nations.Find(id);
            if (nationModel == null)
            {
                return HttpNotFound();
            }
            return View(nationModel);
        }

        // POST: NationModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NationModel nationModel = db.Nations.Find(id);
            db.Nations.Remove(nationModel);
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

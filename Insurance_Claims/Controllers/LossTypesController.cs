using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Insurance_Claims;

namespace Insurance_Claims.Controllers
{
    public class LossTypesController : Controller
    {
        private InterviewEntities db = new InterviewEntities();

        // GET: LossTypes
        public ActionResult Index()
        {
            return View(db.LossTypes.ToList());
        }

        // GET: LossTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LossType lossType = db.LossTypes.Find(id);
            if (lossType == null)
            {
                return HttpNotFound();
            }
            return View(lossType);
        }

        // GET: LossTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LossTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LossTypeId,LossTypeCode,LossTypeDescription,Active,LastUpdatedDate,LastUpdatedId,CreatedDate,CreatedId")] LossType lossType)
        {
            if (ModelState.IsValid)
            {
                db.LossTypes.Add(lossType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lossType);
        }

        // GET: LossTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LossType lossType = db.LossTypes.Find(id);
            if (lossType == null)
            {
                return HttpNotFound();
            }
            return View(lossType);
        }

        // POST: LossTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LossTypeId,LossTypeCode,LossTypeDescription,Active,LastUpdatedDate,LastUpdatedId,CreatedDate,CreatedId")] LossType lossType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lossType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lossType);
        }

        // GET: LossTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LossType lossType = db.LossTypes.Find(id);
            if (lossType == null)
            {
                return HttpNotFound();
            }
            return View(lossType);
        }

        // POST: LossTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LossType lossType = db.LossTypes.Find(id);
            db.LossTypes.Remove(lossType);
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

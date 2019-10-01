using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cb716316_christian_MIS4200.DAL;
using cb716316_christian_MIS4200.Models;

namespace cb716316_christian_MIS4200.Controllers
{
    public class ClassDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: ClassDetails
        public ActionResult Index()
        {
            var classDetails = db.ClassDetails.Include(c => c.Schedule).Include(c => c.Student);
            return View(classDetails.ToList());
        }

        // GET: ClassDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassDetails classDetails = db.ClassDetails.Find(id);
            if (classDetails == null)
            {
                return HttpNotFound();
            }
            return View(classDetails);
        }

        // GET: ClassDetails/Create
        public ActionResult Create()
        {
            ViewBag.scheduleID = new SelectList(db.Schedules, "scheduleID", "semester");
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName");
            return View();
        }

        // POST: ClassDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "classID,className,classRoom,profLastName,scheduleID,studentID")] ClassDetails classDetails)
        {
            if (ModelState.IsValid)
            {
                db.ClassDetails.Add(classDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.scheduleID = new SelectList(db.Schedules, "scheduleID", "semester", classDetails.scheduleID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName", classDetails.studentID);
            return View(classDetails);
        }

        // GET: ClassDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassDetails classDetails = db.ClassDetails.Find(id);
            if (classDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.scheduleID = new SelectList(db.Schedules, "scheduleID", "semester", classDetails.scheduleID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName", classDetails.studentID);
            return View(classDetails);
        }

        // POST: ClassDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "classID,className,classRoom,profLastName,scheduleID,studentID")] ClassDetails classDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.scheduleID = new SelectList(db.Schedules, "scheduleID", "semester", classDetails.scheduleID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName", classDetails.studentID);
            return View(classDetails);
        }

        // GET: ClassDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassDetails classDetails = db.ClassDetails.Find(id);
            if (classDetails == null)
            {
                return HttpNotFound();
            }
            return View(classDetails);
        }

        // POST: ClassDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClassDetails classDetails = db.ClassDetails.Find(id);
            db.ClassDetails.Remove(classDetails);
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

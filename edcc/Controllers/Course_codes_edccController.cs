using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using edcc.Models;

namespace edcc.Controllers
{
    public class Course_codes_edccController : Controller
    {
        private edcc_advisingDbContex db = new edcc_advisingDbContex();

        // GET: Course_codes_edcc
        public ActionResult Index()
        {
            return View(db.Course_codes_edcc.ToList());
        }

        // GET: Course_codes_edcc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_codes_edcc course_codes_edcc = db.Course_codes_edcc.Find(id);
            if (course_codes_edcc == null)
            {
                return HttpNotFound();
            }
            return View(course_codes_edcc);
        }

        // GET: Course_codes_edcc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course_codes_edcc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "edcc_Course_code_id,edccCourse,course_id")] Course_codes_edcc course_codes_edcc)
        {
            if (ModelState.IsValid)
            {
                db.Course_codes_edcc.Add(course_codes_edcc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(course_codes_edcc);
        }

        // GET: Course_codes_edcc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_codes_edcc course_codes_edcc = db.Course_codes_edcc.Find(id);
            if (course_codes_edcc == null)
            {
                return HttpNotFound();
            }
            return View(course_codes_edcc);
        }

        // POST: Course_codes_edcc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "edcc_Course_code_id,edccCourse,course_id")] Course_codes_edcc course_codes_edcc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course_codes_edcc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course_codes_edcc);
        }

        // GET: Course_codes_edcc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_codes_edcc course_codes_edcc = db.Course_codes_edcc.Find(id);
            if (course_codes_edcc == null)
            {
                return HttpNotFound();
            }
            return View(course_codes_edcc);
        }

        // POST: Course_codes_edcc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course_codes_edcc course_codes_edcc = db.Course_codes_edcc.Find(id);
            db.Course_codes_edcc.Remove(course_codes_edcc);
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

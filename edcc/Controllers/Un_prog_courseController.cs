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
    public class Un_prog_courseController : Controller
    {
        private edcc_advisingDbContex db = new edcc_advisingDbContex();

        // GET: Un_prog_course
        public ActionResult Index()
        {
            var un_prog_course = db.Un_prog_course.Include(u => u.Course_codes_org).Include(u => u.Cours).Include(u => u.CourseType).Include(u => u.Program).Include(u => u.University).Include(u => u.Course_codes_edcc);
            return View(un_prog_course.ToList());
        }

        // GET: Un_prog_course/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Un_prog_course un_prog_course = db.Un_prog_course.Find(id);
            if (un_prog_course == null)
            {
                return HttpNotFound();
            }
            return View(un_prog_course);
        }

        // GET: Un_prog_course/Create
        public ActionResult Create()
        {
            ViewBag.course_code_org_id = new SelectList(db.Course_codes_org, "Course_code_id", "Course_");
            ViewBag.course_id = new SelectList(db.Courses, "course_id", "course_name");
            ViewBag.courseType_id = new SelectList(db.CourseTypes, "CoType_id", "course_type");
            ViewBag.prog_id = new SelectList(db.Programs, "prog_id", "prog_name");
            ViewBag.un_id = new SelectList(db.Universities, "un_id", "un_name");
            ViewBag.course_code_edcc_id = new SelectList(db.Course_codes_edcc, "edcc_Course_code_id", "edccCourse");
            return View();
        }

        // POST: Un_prog_course/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,un_id,prog_id,course_id,courseType_id,course_code_org_id,course_code_edcc_id")] Un_prog_course un_prog_course)
        {
            if (ModelState.IsValid)
            {
                db.Un_prog_course.Add(un_prog_course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.course_code_org_id = new SelectList(db.Course_codes_org, "Course_code_id", "Course_", un_prog_course.course_code_org_id);
            ViewBag.course_id = new SelectList(db.Courses, "course_id", "course_name", un_prog_course.course_id);
            ViewBag.courseType_id = new SelectList(db.CourseTypes, "CoType_id", "course_type", un_prog_course.courseType_id);
            ViewBag.prog_id = new SelectList(db.Programs, "prog_id", "prog_name", un_prog_course.prog_id);
            ViewBag.un_id = new SelectList(db.Universities, "un_id", "un_name", un_prog_course.un_id);
            ViewBag.course_code_edcc_id = new SelectList(db.Course_codes_edcc, "edcc_Course_code_id", "edccCourse", un_prog_course.course_code_edcc_id);
            return View(un_prog_course);
        }

        // GET: Un_prog_course/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Un_prog_course un_prog_course = db.Un_prog_course.Find(id);
            if (un_prog_course == null)
            {
                return HttpNotFound();
            }
            ViewBag.course_code_org_id = new SelectList(db.Course_codes_org, "Course_code_id", "Course_", un_prog_course.course_code_org_id);
            ViewBag.course_id = new SelectList(db.Courses, "course_id", "course_name", un_prog_course.course_id);
            ViewBag.courseType_id = new SelectList(db.CourseTypes, "CoType_id", "course_type", un_prog_course.courseType_id);
            ViewBag.prog_id = new SelectList(db.Programs, "prog_id", "prog_name", un_prog_course.prog_id);
            ViewBag.un_id = new SelectList(db.Universities, "un_id", "un_name", un_prog_course.un_id);
            ViewBag.course_code_edcc_id = new SelectList(db.Course_codes_edcc, "edcc_Course_code_id", "edccCourse", un_prog_course.course_code_edcc_id);
            return View(un_prog_course);
        }

        // POST: Un_prog_course/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,un_id,prog_id,course_id,courseType_id,course_code_org_id,course_code_edcc_id")] Un_prog_course un_prog_course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(un_prog_course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.course_code_org_id = new SelectList(db.Course_codes_org, "Course_code_id", "Course_", un_prog_course.course_code_org_id);
            ViewBag.course_id = new SelectList(db.Courses, "course_id", "course_name", un_prog_course.course_id);
            ViewBag.courseType_id = new SelectList(db.CourseTypes, "CoType_id", "course_type", un_prog_course.courseType_id);
            ViewBag.prog_id = new SelectList(db.Programs, "prog_id", "prog_name", un_prog_course.prog_id);
            ViewBag.un_id = new SelectList(db.Universities, "un_id", "un_name", un_prog_course.un_id);
            ViewBag.course_code_edcc_id = new SelectList(db.Course_codes_edcc, "edcc_Course_code_id", "edccCourse", un_prog_course.course_code_edcc_id);
            return View(un_prog_course);
        }

        // GET: Un_prog_course/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Un_prog_course un_prog_course = db.Un_prog_course.Find(id);
            if (un_prog_course == null)
            {
                return HttpNotFound();
            }
            return View(un_prog_course);
        }

        // POST: Un_prog_course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Un_prog_course un_prog_course = db.Un_prog_course.Find(id);
            db.Un_prog_course.Remove(un_prog_course);
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

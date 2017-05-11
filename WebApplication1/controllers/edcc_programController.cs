using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using edccAdvisingProject.Models;

namespace edccAdvisingProject.controllers
{
    public class edcc_programController : Controller
    {
        private edcc_advisingEntities db = new edcc_advisingEntities();

        // GET: edcc_program
        public ActionResult Index()
        {
            return View(db.edcc_program.ToList());
        }

        // GET: edcc_program/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            edcc_program edcc_program = db.edcc_program.Find(id);
            if (edcc_program == null)
            {
                return HttpNotFound();
            }
            return View(edcc_program);
        }

        // GET: edcc_program/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: edcc_program/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ProgCode,ProgramName")] edcc_program edcc_program)
        {
            if (ModelState.IsValid)
            {
                db.edcc_program.Add(edcc_program);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(edcc_program);
        }

        // GET: edcc_program/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            edcc_program edcc_program = db.edcc_program.Find(id);
            if (edcc_program == null)
            {
                return HttpNotFound();
            }
            return View(edcc_program);
        }

        // POST: edcc_program/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ProgCode,ProgramName")] edcc_program edcc_program)
        {
            if (ModelState.IsValid)
            {
                db.Entry(edcc_program).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(edcc_program);
        }

        // GET: edcc_program/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            edcc_program edcc_program = db.edcc_program.Find(id);
            if (edcc_program == null)
            {
                return HttpNotFound();
            }
            return View(edcc_program);
        }

        // POST: edcc_program/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            edcc_program edcc_program = db.edcc_program.Find(id);
            db.edcc_program.Remove(edcc_program);
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

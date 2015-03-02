using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TimeCard.Models;

namespace TimeCard.Controllers
{
    public class ClockInClassesController : Controller
    {
        private ViewModelDbContext db = new ViewModelDbContext();

        // GET: ClockInClasses
        public ActionResult Index()
        {
            return View(db.ClockInClassName.ToList());
        }

        // GET: ClockInClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClockInClass clockInClass = db.ClockInClassName.Find(id);
            if (clockInClass == null)
            {
                return HttpNotFound();
            }
            return View(clockInClass);
        }

        // GET: ClockInClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClockInClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ClockIn,WorkOrder,JobType,Location")] ClockInClass clockInClass)
        {
            if (ModelState.IsValid)
            {
                db.ClockInClassName.Add(clockInClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clockInClass);
        }

        // GET: ClockInClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClockInClass clockInClass = db.ClockInClassName.Find(id);
            if (clockInClass == null)
            {
                return HttpNotFound();
            }
            return View(clockInClass);
        }

        // POST: ClockInClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ClockIn,WorkOrder,JobType,Location")] ClockInClass clockInClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clockInClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clockInClass);
        }

        // GET: ClockInClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClockInClass clockInClass = db.ClockInClassName.Find(id);
            if (clockInClass == null)
            {
                return HttpNotFound();
            }
            return View(clockInClass);
        }

        // POST: ClockInClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClockInClass clockInClass = db.ClockInClassName.Find(id);
            db.ClockInClassName.Remove(clockInClass);
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

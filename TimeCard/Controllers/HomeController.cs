using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeCard.Models;

namespace TimeCard.Controllers
{
    public class HomeController : Controller
    {
        public ViewModelDbContext db = new ViewModelDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult GetGameListing()
        {
            ClockInClass m = new ClockInClass();  // do whatever you need to get your model          
            return PartialView(m);
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
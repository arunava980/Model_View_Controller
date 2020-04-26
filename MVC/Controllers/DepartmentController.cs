using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private MVC_Authenticate_AuthorizeEntities db = new MVC_Authenticate_AuthorizeEntities();

        // GET: Department
        [Authorize(Roles ="V,A")]
        public ActionResult Index()
        {
            return View(db.tbl_Dept.ToList());
        }

        // GET: Department/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Dept tbl_Dept = db.tbl_Dept.Find(id);
            if (tbl_Dept == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Dept);
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DId,DName,HOD")] tbl_Dept tbl_Dept)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Dept.Add(tbl_Dept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Dept);
        }

        // GET: Department/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Dept tbl_Dept = db.tbl_Dept.Find(id);
            if (tbl_Dept == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Dept);
        }

        // POST: Department/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DId,DName,HOD")] tbl_Dept tbl_Dept)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Dept).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Dept);
        }

        // GET: Department/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Dept tbl_Dept = db.tbl_Dept.Find(id);
            if (tbl_Dept == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Dept);
        }

        // POST: Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Dept tbl_Dept = db.tbl_Dept.Find(id);
            db.tbl_Dept.Remove(tbl_Dept);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.EF;
using PagedList;

namespace CaMauTravel.Areas.Admin.Controllers
{
    public class OdersController : BaseController
    {
        private CaMauTravelDBContext db = new CaMauTravelDBContext();

        // GET: Admin/Oders
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            var dao = new OrderDAO();

            var model = dao.ListAllPaging(searchString, page, pageSize);
            ViewBag.SearchString = searchString;

            return View(model);
        }

        // GET: Admin/Oders/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oder oder = db.Oders.Find(id);
            if (oder == null)
            {
                return HttpNotFound();
            }
            return View(oder);
        }

        // GET: Admin/Oders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Oders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CustomerID,CreateDate,ShipName,Mobile,Address,Email,Status")] Oder oder)
        {
            if (ModelState.IsValid)
            {
                oder.Status = false;
                db.Oders.Add(oder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oder);
        }

        // GET: Admin/Oders/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oder oder = db.Oders.Find(id);
            if (oder == null)
            {
                return HttpNotFound();
            }
            return View(oder);
        }

        // POST: Admin/Oders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CustomerID,CreateDate,ShipName,Mobile,Address,Email,Status")] Oder oder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oder);
        }

        // GET: Admin/Oders/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oder oder = db.Oders.Find(id);
            if (oder == null)
            {
                return HttpNotFound();
            }
            return View(oder);
        }

        // POST: Admin/Oders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Oder oder = db.Oders.Find(id);
            db.Oders.Remove(oder);
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

        public JsonResult ChangeStatus(long id)
        {
            var result = new OrderDAO().ChangeStatus(id);

            return Json(new
            {
                status = result
            }); ;
        }
    }
}

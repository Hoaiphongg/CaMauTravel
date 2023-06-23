using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.EF;

namespace CaMauTravel.Areas.Admin.Controllers
{
    public class TourisAttrDetailsController : BaseController
    {
        private CaMauTravelDBContext db = new CaMauTravelDBContext();

        // GET: Admin/TourisAttrDetails
        public ActionResult Index()
        {
            return View(db.TourisAttrDetails.ToList());
        }

        // GET: Admin/TourisAttrDetails/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourisAttrDetail tourisAttrDetail = db.TourisAttrDetails.Find(id);
            if (tourisAttrDetail == null)
            {
                return HttpNotFound();
            }
            return View(tourisAttrDetail);
        }

        // GET: Admin/TourisAttrDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/TourisAttrDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SelectTourisAttraction")] TourisAttrDetail tourisAttrDetail)
        {
            if (ModelState.IsValid)
            {
                db.TourisAttrDetails.Add(tourisAttrDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tourisAttrDetail);
        }

        // GET: Admin/TourisAttrDetails/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourisAttrDetail tourisAttrDetail = db.TourisAttrDetails.Find(id);
            if (tourisAttrDetail == null)
            {
                return HttpNotFound();
            }
            return View(tourisAttrDetail);
        }

        // POST: Admin/TourisAttrDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SelectTourisAttraction")] TourisAttrDetail tourisAttrDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tourisAttrDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tourisAttrDetail);
        }

        // GET: Admin/TourisAttrDetails/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourisAttrDetail tourisAttrDetail = db.TourisAttrDetails.Find(id);
            if (tourisAttrDetail == null)
            {
                return HttpNotFound();
            }
            return View(tourisAttrDetail);
        }

        // POST: Admin/TourisAttrDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TourisAttrDetail tourisAttrDetail = db.TourisAttrDetails.Find(id);
            db.TourisAttrDetails.Remove(tourisAttrDetail);
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

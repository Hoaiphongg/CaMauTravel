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
    public class PlaceTypesController : BaseController
    {
        private CaMauTravelDBContext db = new CaMauTravelDBContext();

        // GET: Admin/PlaceTypes
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            var dao = new PlaceTypeDAO();
            var model = dao.ListAllPaging(searchString, page, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }

        // GET: Admin/PlaceTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlaceType placeType = db.PlaceTypes.Find(id);
            if (placeType == null)
            {
                return HttpNotFound();
            }
            return View(placeType);
        }

        // GET: Admin/PlaceTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/PlaceTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,MetaTitle,ParentID,DisplayOrder,SeoTitle,CreateDate,MetaWords,MetaDescription,Status")] PlaceType placeType)
        {
            if (ModelState.IsValid)
            {
                db.PlaceTypes.Add(placeType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(placeType);
        }

        // GET: Admin/PlaceTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlaceType placeType = db.PlaceTypes.Find(id);
            if (placeType == null)
            {
                return HttpNotFound();
            }
            return View(placeType);
        }

        // POST: Admin/PlaceTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,MetaTitle,ParentID,DisplayOrder,SeoTitle,CreateDate,MetaWords,MetaDescription,Status")] PlaceType placeType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(placeType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(placeType);
        }

        // GET: Admin/PlaceTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlaceType placeType = db.PlaceTypes.Find(id);
            if (placeType == null)
            {
                return HttpNotFound();
            }
            return View(placeType);
        }

        // POST: Admin/PlaceTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlaceType placeType = db.PlaceTypes.Find(id);
            db.PlaceTypes.Remove(placeType);
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

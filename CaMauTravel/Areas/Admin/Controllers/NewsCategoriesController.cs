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
    public class NewsCategoriesController : BaseController
    {
        private CaMauTravelDBContext db = new CaMauTravelDBContext();

        // GET: Admin/NewsCategories
        public ActionResult Index()
        {
            return View(db.NewsCategories.ToList());
        }

        // GET: Admin/NewsCategories/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsCategory newsCategory = db.NewsCategories.Find(id);
            if (newsCategory == null)
            {
                return HttpNotFound();
            }
            return View(newsCategory);
        }

        // GET: Admin/NewsCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/NewsCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,MetaTitle,ParentID,DisplayOrder,SeoTitle,CreateDate,MetaWords,MetaDescription,Status")] NewsCategory newsCategory)
        {
            if (ModelState.IsValid)
            {
                db.NewsCategories.Add(newsCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newsCategory);
        }

        // GET: Admin/NewsCategories/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsCategory newsCategory = db.NewsCategories.Find(id);
            if (newsCategory == null)
            {
                return HttpNotFound();
            }
            return View(newsCategory);
        }

        // POST: Admin/NewsCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,MetaTitle,ParentID,DisplayOrder,SeoTitle,CreateDate,MetaWords,MetaDescription,Status")] NewsCategory newsCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newsCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newsCategory);
        }

        // GET: Admin/NewsCategories/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsCategory newsCategory = db.NewsCategories.Find(id);
            if (newsCategory == null)
            {
                return HttpNotFound();
            }
            return View(newsCategory);
        }

        // POST: Admin/NewsCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            NewsCategory newsCategory = db.NewsCategories.Find(id);
            db.NewsCategories.Remove(newsCategory);
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

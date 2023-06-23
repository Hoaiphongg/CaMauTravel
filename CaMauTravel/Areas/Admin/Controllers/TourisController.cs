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
    public class TourisController : BaseController
    {
        private CaMauTravelDBContext db = new CaMauTravelDBContext();

        // GET: Admin/Touris
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            var dao = new TourisDAO();

            var model = dao.ListAllPaging(searchString, page, pageSize);
            ViewBag.SearchString = searchString;

            return View(model);
        }

        // GET: Admin/Touris/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Touri touri = db.Touris.Find(id);
            if (touri == null)
            {
                return HttpNotFound();
            }
            return View(touri);
        }

        // GET: Admin/Touris/Create
        public ActionResult Create()
        {
            ViewBag.TourisDetailID = new SelectList(db.TourisAttrDetails, "ID", "SelectTourisAttraction");
            ViewBag.PlaceTypeID = new SelectList(db.PlaceTypes, "ID", "Name");
            return View();
        }

        // POST: Admin/Touris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Description,Image,Price,PlaceTypeID,Schedule,Quanlity,TourisDetailID,MetaTitle")] Touri touri)
        {
            if (ModelState.IsValid)
            {
                touri.Status = true;
                touri.CreateDate = DateTime.Now;
                db.Touris.Add(touri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TourisDetailID = new SelectList(db.TourisAttrDetails, "ID", "SelectTourisAttraction", touri.TourisDetailID);
            ViewBag.PlaceTypeID = new SelectList(db.PlaceTypes, "ID", "Name");
            return View(touri);
        }

        // GET: Admin/Touris/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Touri touri = db.Touris.Find(id);
            if (touri == null)
            {
                return HttpNotFound();
            }
            ViewBag.TourisDetailID = new SelectList(db.TourisAttrDetails, "ID", "SelectTourisAttraction", touri.TourisDetailID);
            ViewBag.PlaceTypeID = new SelectList(db.PlaceTypes, "ID", "Name", touri.PlaceTypeID);
            return View(touri);
        }

        // POST: Admin/Touris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,Image,MoreImage,Price,PlaceTypeID,Schedule,PromotionPrice,Quanlity,TourisDetailID,MetaTitle,ParentID,DisplayOrder,SeoTitle,CreateDate,MetaWords,MetaDescription,Status,TopHot")] Touri touri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(touri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TourisDetailID = new SelectList(db.TourisAttrDetails, "ID", "SelectTourisAttraction", touri.TourisDetailID);
            ViewBag.PlaceTypeID = new SelectList(db.PlaceTypes, "ID", "Name", touri.PlaceTypeID);
            return View(touri);
        }

        // GET: Admin/Touris/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Touri touri = db.Touris.Find(id);
            if (touri == null)
            {
                return HttpNotFound();
            }
            return View(touri);
        }

        // POST: Admin/Touris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Touri touri = db.Touris.Find(id);
            db.Touris.Remove(touri);
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

        [HttpPost]
        public JsonResult ChangeStatus(long id)
        {
            var result = new TourisDAO().ChangeStatus(id);

            return Json(new
            {
                status = result
            }); ;
        }
    }
}

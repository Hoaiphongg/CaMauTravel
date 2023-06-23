using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CaMauTravel.Common;
using Model.DAO;
using Model.EF;
using PagedList;

namespace CaMauTravel.Areas.Admin.Controllers
{
    public class TouristAttractionsController : BaseController
    {
        private CaMauTravelDBContext db = new CaMauTravelDBContext();

        // GET: Admin/TouristAttractions
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            var dao = new TourisAttractionDAO();
            var model = dao.ListAllPaging(searchString, page, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }

        // GET: Admin/TouristAttractions/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TouristAttraction touristAttraction = db.TouristAttractions.Find(id);
            if (touristAttraction == null)
            {
                return HttpNotFound();
            }
            return View(touristAttraction);
        }

        // GET: Admin/TouristAttractions/Create
        public ActionResult Create()
        {
            ViewBag.PlaceTypeID = new SelectList(db.PlaceTypes, "ID", "Name");

            return View();
        }

        // POST: Admin/TouristAttractions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Images,Description,PlaceTypeID,MetaTitle")] TouristAttraction touristAttraction)
        {
            if (ModelState.IsValid)
            {
                touristAttraction.CreateDate = DateTime.Now;
                touristAttraction.Status = true;
                touristAttraction.ParentID = 1;
                touristAttraction.DisplayOrder = 1;
                db.TouristAttractions.Add(touristAttraction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlaceTypeID = new SelectList(db.PlaceTypes, "ID", "Name");
            return View(touristAttraction);
        }

        public ActionResult CreateAndEditMultiTouris(int id = 0)
        {
            TourisAttrDetail tourisAttrDetail = new TourisAttrDetail();
            using (CaMauTravelDBContext CMD = new CaMauTravelDBContext())
            {
                if (id != 0)
                {
                    tourisAttrDetail = CMD.TourisAttrDetails.Where(x => x.ID == id).FirstOrDefault();

                    tourisAttrDetail.SelectedIDArray = tourisAttrDetail.SelectTourisAttraction.Split(',').ToArray();
                }
                tourisAttrDetail.DetailCollection = CMD.TouristAttractions.ToList();
            }

            return View(tourisAttrDetail);
        }

        [HttpPost]
        public ActionResult CreateAndEditMultiTouris(TourisAttrDetail tourisAttrDetail)
        {
            tourisAttrDetail.SelectTourisAttraction = string.Join(",", tourisAttrDetail.SelectedIDArray);
            using (CaMauTravelDBContext CMD = new CaMauTravelDBContext())
            {
                if (tourisAttrDetail.ID == 0)
                {
                    CMD.TourisAttrDetails.Add(tourisAttrDetail);
                    CMD.SaveChanges();
                }
                else
                {
                    db.Entry(tourisAttrDetail).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            return RedirectToAction("CreateAndEditMultiTouris", new { id = 0 });
        }

        // GET: Admin/TouristAttractions/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TouristAttraction touristAttraction = db.TouristAttractions.Find(id);
            if (touristAttraction == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlaceTypeID = new SelectList(db.PlaceTypes, "ID", "Name", touristAttraction.PlaceTypeID);
            return View(touristAttraction);
        }

        // POST: Admin/TouristAttractions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Images,Description,PlaceTypeID,MetaTitle,ParentID,DisplayOrder,SeoTitle,CreateDate,MetaWords,MetaDescription,Status")] TouristAttraction touristAttraction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(touristAttraction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlaceTypeID = new SelectList(db.PlaceTypes, "ID", "Name", touristAttraction.PlaceTypeID);
            return View(touristAttraction);
        }

        // GET: Admin/TouristAttractions/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TouristAttraction touristAttraction = db.TouristAttractions.Find(id);
            if (touristAttraction == null)
            {
                return HttpNotFound();
            }
             ViewBag.PlaceTypeID = new SelectList(db.PlaceTypes, "ID", "Name", touristAttraction.PlaceTypeID);
            return View(touristAttraction);
        }

        // POST: Admin/TouristAttractions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TouristAttraction touristAttraction = db.TouristAttractions.Find(id);
            db.TouristAttractions.Remove(touristAttraction);
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
            var result = new TourisAttractionDAO().ChangeStatus(id);

            return Json(new
            {
                status = result
            }); ;
        }
    }
}

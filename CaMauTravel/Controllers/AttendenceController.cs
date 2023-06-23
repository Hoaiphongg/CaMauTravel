using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaMauTravel.Controllers
{
    public class AttendenceController : Controller
    {
        // GET: Attendence
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult PlaceType()
        {
            var model = new PlaceTypeDAO().listAll();
            return PartialView(model);
        }

        public ActionResult PlaceTypeAttraction(int attID, int page = 1, int pageSize = 1)
        {
            var placeType = new PlaceTypeDAO().Detail(attID);
            ViewBag.PlaceType = placeType;
            int totalRecord = 0;
            var model = new TourisAttractionDAO().ListByPlaceType(attID, ref totalRecord, page, pageSize);

            ViewBag.Total = totalRecord;
            ViewBag.Page = page;

            int maxPage = 5;
            int totalPage = 0;

            totalPage = (int)Math.Ceiling((double)(totalRecord / pageSize));
            ViewBag.TotalPage = totalPage;
            ViewBag.Maxpage = maxPage;
            ViewBag.First = 1;
            ViewBag.Last = totalPage;
            ViewBag.Next = page + 1;
            ViewBag.Pre = page - 1;

            return View(model);
        }
        public ActionResult Detail(long id)
        {
            var attraction = new TourisAttractionDAO().Detail(id);
            ViewBag.Detail = new PlaceTypeDAO().Detail(attraction.PlaceTypeID.Value);

            return View(attraction);
        }
    }
}
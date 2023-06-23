using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;

namespace CaMauTravel.Controllers
{
    public class TourisUserController : Controller
    {
        // GET: Touris
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

        public ActionResult PlaceTypeTouris(int placeID, int page = 1, int pageSize = 1)
        {
            var placeType = new PlaceTypeDAO().Detail(placeID);
            ViewBag.PlaceType = placeType;
            int totalRecord = 0;
            var model = new TourisDAO().ListByPlaceType(placeID,ref totalRecord , page, pageSize);

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
            var touris = new TourisDAO().Detail(id);
            ViewBag.Detail = new PlaceTypeDAO().Detail(touris.PlaceTypeID.Value);

            return View(touris);
        }
    }
}
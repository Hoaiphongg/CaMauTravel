using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaMauTravel.Controllers
{
    public class TourisAttractionsController : Controller
    {
        // GET: TourisAttendences
        public ActionResult Index()
        {
            TourisAttractionDAO dao = new TourisAttractionDAO();
            ViewBag.ListAll = dao.getTouris();

            return View();
        }

        public ActionResult Detail(long id)
        {
            var touris = new TourisAttractionDAO().Detail(id);
            ViewBag.Detail = new PlaceTypeDAO().Detail(touris.PlaceTypeID.Value);

            return View(touris);
        }
    }
}
using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaMauTravel.Controllers
{
    public class ShoptController : Controller
    {
        // GET: Shopt
        public ActionResult Index()
        {
            TourisDAO touris = new TourisDAO();
            ViewBag.ListAll = touris.ListAll();
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult TopHot()
        {
            var model = new TourisDAO().ListHot(5);
            ViewBag.ListHot = model;
            return PartialView(model);
        }

        [ChildActionOnly]
        public PartialViewResult RelatedTouris()
        {
            var model = new TourisDAO().ReletedTouris();
            ViewBag.RelatedTouris = model;
            return PartialView(model);
        }

    }
}
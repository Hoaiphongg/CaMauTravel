using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaMauTravel.Controllers
{
    public class MainHomeController : Controller
    {
        // GET: MainHome
        public ActionResult Index()
        {
            var tourisDao = new TourisDAO();
            ViewBag.ListNewTouris = tourisDao.ListNewTouris(4);
            ViewBag.ListHot = tourisDao.ListHot(4);
            return View();
        }
        
    }
}
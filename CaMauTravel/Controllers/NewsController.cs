using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;

namespace CaMauTravel.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            NewsDAO news = new NewsDAO();
            ViewBag.ListAll = news.ListAll();
            return View();
        }

        public ActionResult Detail(long id)
        {
            var news = new NewsDAO().Detail(id);
            ViewBag.Detail = new NewsDAO().Detail(id);

            return View(news);
        }
    }
}
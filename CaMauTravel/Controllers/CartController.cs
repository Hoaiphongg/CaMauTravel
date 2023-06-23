using CaMauTravel.Models;
using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CaMauTravel.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";
        // GET: Cart
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if(cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }
        public ActionResult AddItem(long tourisID, int quanlity)
        {
            var touris = new TourisDAO().Detail(tourisID);
            var cart = Session[CartSession];
            if(cart != null)
            {
                var list = (List<CartItem>)cart;
                if(list.Exists(x => x.Touri.ID == tourisID))
                {
                    foreach(var item in list)
                    {
                        if(item.Touri.ID == tourisID)
                        {
                            item.Quanlity += quanlity;
                        }
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.Touri = touris;
                    item.Quanlity = quanlity;
                    list.Add(item);
                }
                Session[CartSession] = list;
            }
            else
            {
                var item = new CartItem();
                item.Touri = touris;
                item.Quanlity = quanlity;
                var list = new List<CartItem>();
                list.Add(item);
                Session[CartSession] = list;

            }

            return RedirectToAction("Index");
            
        }

        public JsonResult Update(string cartModel)
        {
            var cartJson = new JavaScriptSerializer().Deserialize<List<CartItem>>(cartModel);
            var cartSession = (List<CartItem>)Session[CartSession];

            foreach (var item in cartSession)
            {
                var jsonItem = cartJson.SingleOrDefault(x => x.Touri.ID == item.Touri.ID);
                if(jsonItem != null)
                {
                    item.Quanlity = jsonItem.Quanlity;
                }
            }
            Session[CartSession] = cartSession;
            return Json(new
            {
                status = true
            });
        }

        public JsonResult DeleteAll()
        {
            Session[CartSession] = null;
            return Json(new
            {
                status = true
            });
        }

        public JsonResult Delete(long id)
        {

            var sessionCart = (List<CartItem>)Session[CartSession];
            sessionCart.RemoveAll(x => x.Touri.ID == id);
            Session[CartSession] = sessionCart;


            return Json(new
            {
                status = true
            });
        }

        [HttpGet]
        public ActionResult Payment()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        [HttpPost]
        public ActionResult Payment(string shipName, string mobile, string address, string email)
        {
            var order = new Oder();
            order.CreateDate = DateTime.Now;
            order.Address = address;
            order.Mobile = mobile;
            order.ShipName = shipName;
            order.Email = email;

            try
            {
                var id = new OrderDAO().Insert(order);
                var cart = (List<CartItem>)Session[CartSession];
                var detailDao = new Model.DAO.OrderDetailDAO();
                decimal total = 0;
                foreach (var item in cart)
                {
                    var orderDetail = new OderDetail();
                    orderDetail.TourisID = item.Touri.ID;
                    orderDetail.OrderID = id;
                    orderDetail.Price = item.Touri.Price;
                    orderDetail.Quanlity = item.Quanlity;
                    detailDao.Insert(orderDetail);

                    total += (item.Touri.Price.GetValueOrDefault(0) * item.Quanlity);
                }
            }
            catch (Exception ex)
            {
                //ghi log
                return Redirect("/payment-fall");
            }
            return Redirect("/success");
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
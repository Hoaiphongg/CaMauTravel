using CaMauTravel.Areas.Admin.Model;
using CaMauTravel.Common;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaMauTravel.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new AccountDAO();

                var result = dao.AdminLogin(model.UserName, Encryptor.MD5Hash(model.Password));

                if (result == 1)
                {
                    var account = dao.GetByID(model.UserName);
                    var accountSession = new AdminLogin();
                    accountSession.UserName = account.username;
                    accountSession.Account_ID = account.account_id;


                    Session.Add(CommonConstants.USER_SESSION, accountSession);
                    return RedirectToAction("Index","Home");
                }
                else if(result == 0)
                {
                    ModelState.AddModelError("", "No Account!!");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Account has be Lock!!");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Account is empty Password!!");
                }
                else
                {
                    ModelState.AddModelError("", "Account is empty!!");
                }
            }
            return View("Index");
        }
    }
}
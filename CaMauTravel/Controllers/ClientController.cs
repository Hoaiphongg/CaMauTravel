using CaMauTravel.Common;
using CaMauTravel.Models;
using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaMauTravel.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModels registerModels)
        {
            if (ModelState.IsValid) {
                var dao = new AccountDAO();
                if (dao.CheckUsername(registerModels.UserName)) {
                    ModelState.AddModelError("", "Username is Exist!!");
                } else if (dao.CheckEmail(registerModels.Email))
                {
                    ModelState.AddModelError("", "Email is Exist!!");
                }
                else
                {
                    var account = new Account();
                    account.username = registerModels.UserName;

                    var encryptMDPassword = Encryptor.MD5Hash(registerModels.Password);
                    account.password = encryptMDPassword;
                    account.name = registerModels.Name;
                    account.email = registerModels.Email;
                    account.phone = registerModels.Phone;
                    account.address = registerModels.Address;
                    account.gender = registerModels.Gender;
                    account.birthday = registerModels.Birthday;
                    account.roll = 1;
                    account.status = true;

                    var result = dao.Insert(account);
                    if (result > 0) {
                        ViewBag.Sucess = "Sign Up Sucess! ";
                    }
                    else
                    {
                        ModelState.AddModelError("", "Can't Sign Up");
                    }
                }

            }
            return RedirectToAction("Index", "MainHome");
        }

        public ActionResult Logout()
        {
            Session[CommonConstants.USER_SESSION] = null;
            return Redirect("/");
        }

        [HttpPost]
        public ActionResult Login(LoginModels model)
        {
            if (ModelState.IsValid)
            {
                var userDao = new AccountDAO();

                var res = userDao.ClientLogin(model.Username, Encryptor.MD5Hash(model.Passwords));
                if (res == 1)
                {
                    var u = userDao.GetByID(model.Username);
                    var userSession = new ClientLogin();
                    userSession.UserName = u.username;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "MainHome");
                }
                else if (res == 0)
                {
                    ModelState.AddModelError("", "User no find.");
                }
                else if (res == -1)
                {
                    ModelState.AddModelError("", "User have been Clocked.");
                }
                else if (res == -2)
                {
                    ModelState.AddModelError("", "Password invalid.");
                }
                else
                {
                    ModelState.AddModelError("", "username or password invalid.");
                }
            }

            return View(model);
        }
    }
}
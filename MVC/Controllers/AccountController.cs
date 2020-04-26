using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tbl_User user)
        {
            MVC_Authenticate_AuthorizeEntities db = new MVC_Authenticate_AuthorizeEntities();
            var count = db.tbl_User.Where(x => x.UserName == user.UserName && x.Password == user.Password).Count();
            if (count == 0)
            {
                ViewBag.Mesage = "Invalid User";
                return View();
            }
            else
            {
                FormsAuthentication.SetAuthCookie(user.UserName,false);
                return RedirectToAction("Index","Home");
            }

          }


        public ActionResult Logout(tbl_User user)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Home");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelLayer;
using BusinessLayer;
namespace LetsStart.Controllers
{
    public class HomeController : Controller
    {
        BLUser objBLUser = null;

        #region Login User View
        [HttpGet]
        public ActionResult Login()
        {
            MLUser objMLUser = new MLUser();
            return View(objMLUser);
        }
        #endregion

        #region Login User
        [HttpPost]
        public ActionResult Login(MLUser objMLUser)
        {
            if (!string.IsNullOrEmpty(objMLUser.EmailID) && !string.IsNullOrEmpty(objMLUser.Password))
            {
                objBLUser = new BLUser();
                var objUserInfo = objBLUser.Login(objMLUser);
                if (objUserInfo != null)
                {
                    if (objUserInfo.UserTypeID == Constants.USERTYPEADMIN)
                    {
                        return RedirectToAction( "Default", "Home", new {Area = "Admin"} );
                    }
                    else
                    {
                        return RedirectToAction("Default", "Home", new { Area = "User" }); 
                    }

                }
                return View();
            }
            else
            {
                return View();
            }
        }
        #endregion

        



    }
}
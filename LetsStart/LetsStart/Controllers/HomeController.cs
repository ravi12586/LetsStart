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
        [HttpGet]
        public ActionResult Login()
        {
            MLUser objMLUser = new MLUser();
            return View(objMLUser);
        }
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







        public ActionResult Error()
        {
            return View();
        }

        public ActionResult MorrisCharts()
        {
            return View("MorrisCharts");
        }

        public ActionResult Tables()
        {
            return View("Tables");
        }

        public ActionResult Forms()
        {
            return View("Forms");
        }

        public ActionResult Panels()
        {
            return View("Panels");
        }

        public ActionResult Buttons()
        {
            return View("Buttons");
        }

        public ActionResult Notifications()
        {
            return View("Notifications");
        }

        public ActionResult Typography()
        {
            return View("Typography");
        }

        public ActionResult Icons()
        {
            return View("Icons");
        }

        public ActionResult Grid()
        {
            return View("Grid");
        }

        public ActionResult Blank()
        {
            return View("Blank");
        }



    }
}
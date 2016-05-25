using LetsStart.Domain;
using LetsStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelLayer;
using BusinessLayer;
namespace LetsStart.Areas.Admin.Controllers
{
    public class NavbarController : Controller
    {
        BLMenu objMenu = null;
        // GET: Navbar
        public ActionResult Index()
        {
            objMenu = new BLMenu();
            var data = objMenu.GetMenuItems(true).ToList();
            return PartialView("_Navbar", data);
        }
    }
}
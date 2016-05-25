using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelLayer;
using BusinessLayer;
namespace LetsStart.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        BLUser objBLUser = null;
        // GET: Admin/Admin
       
        public ActionResult Default()
        {
            return View();
        }
        [HttpGet]
         public ActionResult GetMessages()
        {
            LetsStart.Hubs.MessagesRepository _messageRepository = new LetsStart.Hubs.MessagesRepository();
            return PartialView("_MessageList", _messageRepository.GetAllMessages());
        }
    
    }
}
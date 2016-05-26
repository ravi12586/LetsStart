using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LetsStart.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        // GET: Admin/Message
        [HttpGet]
        public ActionResult GetMessages()
        {
            LetsStart.Hubs.MessagesRepository _messageRepository = new LetsStart.Hubs.MessagesRepository();
            return PartialView("_MessageList", _messageRepository.GetAllMessages());
        }
    }
}
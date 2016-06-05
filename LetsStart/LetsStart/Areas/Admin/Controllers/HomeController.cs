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
        BLAdminHome objBLAdminHome = null;
        BLCommon objBLCommon = null;
        // GET: Admin/Admin
       
        public ActionResult Default()
        {
            return View();
        }

        public ActionResult Questions()
        {
            return View();
        }

        public JsonResult LoadQuestionsList()
        {
            objBLAdminHome = new BLAdminHome();
            var result=objBLAdminHome.LoadQuestionsList();
            return Json(new { data = result.ListQuestionAnswers }, JsonRequestBehavior.AllowGet);
        }

        #region Question Partial
        public ActionResult AddUpdateQuestionPartial(long? questionID)
        {
            MLQuestion objMLQuestion = new MLQuestion();
            objBLCommon=new BLCommon();
            MLDropdownBindOption objMLDDLBind=new MLDropdownBindOption();
            objMLDDLBind.TableName = "tblSubject";
            objMLDDLBind.ColID = "SID";
            objMLDDLBind.ColText = "Subject";
            objMLDDLBind.Option="";
            ViewBag.ListSubject = objBLCommon.GetDropdownList(objMLDDLBind).ToList();

            if (questionID > 0)
            {
                //Fetch records from database
            }
            else
            {
                objMLQuestion.ListAnswers = new List<MLAnswer>{
                    new MLAnswer(),
                    new MLAnswer()
                };
            }

            return PartialView("_AddUpdateQuestion", objMLQuestion);
        }
        #endregion
    }
}
using Elmah;
using LetsStart.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelLayer;
namespace LetsStart.Controllers
{
    public class ErrorController : Controller
    {
        public void Index(MLError objMlError)
        {
            ErrorSignal objErr = new ErrorSignal();
            ErrorSignal.FromCurrentContext()
                .Raise(new JSException
                {
                    Message = objMlError.Message,
                    Url = objMlError.Url,
                    LineNumber = objMlError.LineNumber,
                    Column = objMlError.Column,
                    ErrorStack = objMlError.ErrorStack,
                    User=objMlError.User,
                    Application=objMlError.Application,
                });
        }
    }
}
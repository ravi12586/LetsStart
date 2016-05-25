using System;
using System.Web;
using System.Web.Mvc;

namespace LetsStart
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new LetsStartHandleErrorAttribute());
            filters.Add(new HandleErrorAttribute());
        }
        //public class LetsStartHandleErrorAttribute : HandleErrorAttribute
        //{
        //    public override void OnException(ExceptionContext filterContext)
        //    {
        //        if (filterContext != null)
        //        {
        //            base.OnException(filterContext);
        //        }
        //    }
        //}
    }
}

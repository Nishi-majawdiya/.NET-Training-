using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Application.Filters
{
    public class MyResultFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("Before Result");
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("After Result");
        }
    }
}
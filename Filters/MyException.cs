using System;
using System.Web.Mvc;

namespace MVC_Application.Filters
{
    public class MyException : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.Controller.ViewBag.ErrorMessage =
                filterContext.Exception.Message;

            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };

            filterContext.ExceptionHandled = true;
        }
    }
}
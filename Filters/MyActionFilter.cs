using System.Diagnostics;
using System.Web.Mvc;

namespace MVC_Application.Filters
{
    public class MyActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Before Action Method");
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("After Action");
        }
    }
}
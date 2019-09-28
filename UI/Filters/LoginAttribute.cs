using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Filters
{
    public class LoginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["uName"] == null)
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "Login"
                };
            }
        }
    }
}
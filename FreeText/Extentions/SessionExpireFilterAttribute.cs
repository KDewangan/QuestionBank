using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeText.Core.Web.Extentions
{
    public class SessionExpireFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool isAvailable = filterContext.HttpContext.Session.IsAvailable;

            // check if session is supported
            //Provider ProviderInfo = new Provider();
            //ProviderInfo = filterContext.HttpContext.Session.GetObjectFromJson<Provider>("ProviderInfo");
            //UserLogin UserInfo = new UserLogin();
            //UserInfo = filterContext.HttpContext.Session.GetObjectFromJson<UserLogin>("UserInfo");
            //if (ProviderInfo == null && UserInfo == null)
            //{
            //    filterContext.HttpContext.Response.Redirect("/");
            //    // check if a new session id was generated
            //}

            base.OnActionExecuting(filterContext);
        }
    }

    public class ResponseCacheFilter : ResponseCacheAttribute
    {
        public ResponseCacheFilter() : base()
        {
            Location = ResponseCacheLocation.None;
            NoStore = true;
        }
    }
}

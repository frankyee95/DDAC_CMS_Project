﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DDAC_project.Interfaces;
using DDAC_project.Repository;

namespace DDAC_project.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected IEventsAppService _eventsAppService = null;

        public BaseController()
        {
            string userName = string.Empty;
            if (System.Web.HttpContext.Current.User != null)
            {
                userName = System.Web.HttpContext.Current.User.Identity.Name;
            }
            this._eventsAppService = new AppService(userName);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

        }
    }
}
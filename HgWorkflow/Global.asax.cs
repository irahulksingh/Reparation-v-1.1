﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Globalization;
using System.Threading;


namespace HgWorkflow
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //CultureInfo newCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            //newCulture.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
            //newCulture.DateTimeFormat.DateSeparator = "-";
            //Thread.CurrentThread.CurrentCulture = newCulture;
        }
        //protected void Application_BeginRequest(Object sender, EventArgs e)
        //{
        //    CultureInfo newCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        //    newCulture.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
        //    newCulture.DateTimeFormat.DateSeparator = "-";
        //    Thread.CurrentThread.CurrentCulture = newCulture;
        //}
    }
}

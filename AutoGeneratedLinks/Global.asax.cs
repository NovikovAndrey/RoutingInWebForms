﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace AutoGeneratedLinks
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }
        private void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Calculator", "calc/{operation}/{x}/{y}", "~/Calc.aspx");
        }
    }
}
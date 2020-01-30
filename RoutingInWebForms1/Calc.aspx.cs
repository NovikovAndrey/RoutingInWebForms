﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoutingInWebForms1
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string oper = Page.RouteData.Values["operation"] as string;
            int x = Convert.ToInt32(Page.RouteData.Values["x"]);
            int y = Convert.ToInt32(Page.RouteData.Values["y"]);
            try
            {
                switch(oper)
                {
                    case "sum":
                    {
                            Result.Text = (x + y).ToString();
                            break;
                    }
                    case "sub":
                    {
                            Result.Text = (x - y).ToString();
                            break;
                    }
                    case "mul":
                    {
                            Result.Text = (x * y).ToString();
                            break;
                    }
                    case "div":
                    {
                            Result.Text = (x / y).ToString();
                            break;
                    }
                    default:
                    {
                            throw new Exception();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Result.Text = "Error";
            }

        }
    }
}
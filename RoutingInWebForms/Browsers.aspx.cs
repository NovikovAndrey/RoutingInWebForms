using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoutingInWebForms
{
    public partial class Browsers : System.Web.UI.Page
    {
        Dictionary<string, string> browsers = new Dictionary<string, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            browsers.Add("mozilla", "dsfsdfdsfdsfsdfsdfsd");
            browsers.Add("chrome", "flsdkljsjklfdnjkdshfSKJDJFH");
            browsers.Add("safary", "oiyrergjhduvndkjoiajflweknfw");
            browsers.Add("opera", "uhrkebfjvhdfnreijdmvnalklmdnf");
            browsers.Add("ie", "khdhgreugnljkfdhivbldfjkabngbgouibf");
            try
            {
                string name = Page.RouteData.Values["name"] as string;
                Label1.Text = browsers[name];
            }
            catch
            {
                Label1.Text = "Error";
            }
        }
    }
}
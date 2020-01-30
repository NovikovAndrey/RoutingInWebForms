using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocalizationSample
{
    public partial class Login : System.Web.UI.Page
    {
        protected override void InitializeCulture()
        {
            string lan = Page.RouteData.Values["lang"] as string ?? "auto";
            UICulture = lan;
            base.InitializeCulture();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}
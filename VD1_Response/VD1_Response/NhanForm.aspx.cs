using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD1_Response
{
    public partial class NhanForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "UserName :" + Request.QueryString["Name"].ToString() + "<br> Password:" + Request.QueryString["Pass"].ToString();
        }
    }
}
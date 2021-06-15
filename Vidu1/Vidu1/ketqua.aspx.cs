using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vidu1
{
    public partial class ketqua : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = Request.Form.Get("TextBox1");
            Label3.Text = Request.Form.Get("TextBox2");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
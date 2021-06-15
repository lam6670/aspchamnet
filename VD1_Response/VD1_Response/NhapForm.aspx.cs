using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD1_Response
{
    public partial class NhapForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sName = TextBox1.Text;
            string sPass = TextBox2.Text;
            Response.Redirect("NhanForm.aspx?Name=" + sName + "&pass=" + sPass);
        }
    }
}
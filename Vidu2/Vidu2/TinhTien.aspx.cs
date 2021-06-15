using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vidu2
{
    public partial class TinhTien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double soA, soB, Tong, giatien;
            soA = double.Parse(Request.Form.Get("TextBox1"));
            soB = double.Parse(Request.Form.Get("TextBox2"));
            Tong = soB - soA;
            if (Tong <= 100)
            {
                giatien = Tong * 2000;
            }
            else if (Tong <= 150)
            {
                giatien = 100 * 2000 + (Tong - 100) * 2500;
            }
            else if (Tong <= 200)
            {
                giatien = 100 * 2000 + 50 * 2500 + (Tong - 150) * 2800;
            }
            else
            {
                giatien = 100 * 2000 + 50 * 2500 + 2800 * 50 + (Tong - 200) * 3500;
            }
            TienDien.Text= giatien.ToString();
        }
    }
}
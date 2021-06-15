using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vidu2_response
{
    public partial class TinhTienLuong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double bacluong, ngaycong, ngaycongtinhluong, phucap, tinhtien,manv;
            bacluong = double.Parse(Request.Form.Get("TextBox2"));
            ngaycong = double.Parse(Request.Form.Get("TextBox3"));
            manv = double.Parse(Request.Form.Get("TextBox1"));
            if (ngaycong >= 25)
            {
                ngaycongtinhluong = (ngaycong - 25) * 2 + 25;
            }
            else
            {
                ngaycongtinhluong = ngaycong;
            }

            if (Request.Form.Get("DropDownList1".ToString()) == "Trưởng phòng")
            {
                phucap = 500000;
            }
            else if (Request.Form.Get("DropDownList1".ToString()) == "Phó phòng")
            {
                phucap = 300000;
            }
            else
            {
                phucap = 100000;
            }

            tinhtien = bacluong * 650000 * ngaycongtinhluong + phucap;
            TextBox1.Text = manv.ToString();
            TextBox3.Text = ngaycong.ToString();
            Label5.Text = tinhtien.ToString();
        }
    }
}
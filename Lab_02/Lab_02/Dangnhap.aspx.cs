using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_02
{
    public partial class Dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ID = "phetitc";
            if (txtID.Text == "phetitc" && txtPassword.Text == "123456")
            {
                Response.Redirect("ChaoMung.aspx?txtID=" + ID);
            }
            else
            {
                lblShow.Text = "Tên đăng nhập hoặc mật khẩu không hợp";
            }
        }
    }
}
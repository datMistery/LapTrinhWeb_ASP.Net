using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_02
{
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            String sTap_tin = "Lab02 - Cac doi tuong.Net.pdf";
            String sDuong_dan;
            sDuong_dan = Server.MapPath("~/") + sTap_tin;
            Response.AddHeader("Content-Disposition", "filename =" + sTap_tin);
            Response.WriteFile(sDuong_dan);
            Response.End();
        }
    }
}
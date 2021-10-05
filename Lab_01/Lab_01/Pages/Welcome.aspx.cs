using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_01.Pages
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbNgay.Text = "Hôm nay ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString()
                          + " năm " + DateTime.Now.Year.ToString();
            lbThoigian.Text = "Bây giờ là: " + DateTime.Now.Hour.ToString() + " giờ " + DateTime.Now.Minute.ToString()
                               + " phút " + DateTime.Now.Second.ToString() + " giây ";
        }
    }
}
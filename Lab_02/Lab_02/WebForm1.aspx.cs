using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hôm nay ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString()
                                           + " năm " + DateTime.Now.Year.ToString());
           
        }
    }
}
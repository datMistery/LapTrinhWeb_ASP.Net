using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_02
{
    public partial class ChitietBantin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["MaBT"];
            Response.Write("Đây là nội dung chi tiết bản tin \"" + s + "\"");

        }
    }
}
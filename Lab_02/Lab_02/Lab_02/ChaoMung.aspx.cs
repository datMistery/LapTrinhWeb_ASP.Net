using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_02
{
    public partial class ChaoMung : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblChaoMung.Text = "Chào mừng bạn " + Request.QueryString["txtID"] + " đến với diễn đàn ASP.Net";


        }

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dangnhap.aspx");
        }
    }
}
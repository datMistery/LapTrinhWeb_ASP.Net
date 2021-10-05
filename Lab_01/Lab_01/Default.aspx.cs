using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_01
{
    public partial class Default : System.Web.UI.Page
    {
      

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCong_Click(object sender, EventArgs e)
        {
            int so1, so2, tong;
            so1 = int.Parse(txtSon.Text);
            so2 = int.Parse(txtSom.Text);
            tong = so1 + so2;
            txtKetqua.Text = tong.ToString();
        }

        protected void btnTru_Click(object sender, EventArgs e)
        {
            int so1, so2, tong;
            so1 = int.Parse(txtSon.Text);
            so2 = int.Parse(txtSom.Text);
            tong = so1 - so2;
            txtKetqua.Text = tong.ToString();
        }

        protected void btnNhan_Click(object sender, EventArgs e)
        {
            int so1, so2, tong;
            so1 = int.Parse(txtSon.Text);
            so2 = int.Parse(txtSom.Text);
            tong = so1 * so2;
            txtKetqua.Text = tong.ToString();
        }

        protected void btnChia_Click(object sender, EventArgs e)
        {
            int so1, so2, tong;
            so1 = int.Parse(txtSon.Text);
            so2 = int.Parse(txtSom.Text);
            tong = so1 / so2;
            txtKetqua.Text = tong.ToString();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            txtSom.Text = "";
            txtSon.Text = "";
            txtKetqua.Text = "";
            txtSon.Focus();
        }
    }
}
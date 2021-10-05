using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_01.Pages
{
    public partial class Thuchienpheptinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCong_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int ketqua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            ketqua = a + b;
            txtKetqua.Text = txtA.Text + " + " + txtB.Text + " = " + ketqua;
        }

        protected void btnTru_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int ketqua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            ketqua = a - b;
            txtKetqua.Text = txtA.Text + " - " + txtB.Text + " = " + ketqua;
        }

        protected void btnNhan_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int ketqua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            ketqua = a * b;
            txtKetqua.Text = txtA.Text + " * " + txtB.Text + " = " + ketqua;
        }

        protected void btnChia_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int ketqua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            if (b == 0)
            {
                txtKetqua.Text = "Số nhập vào không hợp lệ";
            }
            else
            {
                ketqua = a / b;
                txtKetqua.Text = txtA.Text + " / " + txtB.Text + " = " + ketqua;
            }
        }

        protected void btnChiaDu_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int ketqua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            if (b == 0)
            {
                txtKetqua.Text = "Số nhập vào không hợp lệ";
            }
            else
            {
                ketqua = a % b;
                txtKetqua.Text = txtA.Text + " % " + txtB.Text + " = " + ketqua;
            }
        }
    }
}
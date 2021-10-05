using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_01.Pages
{
    public partial class Tinhtoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThanhTien_Click(object sender, EventArgs e)
        {
            int soLuong;
            int donGia;
            int thanhTien;
            soLuong = int.Parse(txtSoluong.Text);
            donGia = int.Parse(txtDongia.Text);
            thanhTien = soLuong * donGia;
            txtThanhtien.Text = thanhTien.ToString();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            txtDongia.Text = "";
            txtSoluong.Text = "";
            txtThanhtien.Text = "";
        }
    }
}
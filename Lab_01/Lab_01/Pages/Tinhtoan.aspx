<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tinhtoan.aspx.cs" Inherits="Lab_01.Pages.Tinhtoan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            TÍNH TOÁN<br />
            Số lượng:&nbsp;&nbsp;
            <asp:TextBox ID="txtSoluong" runat="server" Width="92px"></asp:TextBox>
            <br />
            Đơn giá:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDongia" runat="server" Width="92px"></asp:TextBox>
            <br />
            Thành tiền:
            <asp:TextBox ID="txtThanhtien" runat="server" Width="94px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnThanhTien" runat="server" OnClick="btnThanhTien_Click" Text="Thành tiền" />
&nbsp;<asp:Button ID="btnXoa" runat="server" OnClick="btnXoa_Click" Text="Xóa" />
        </div>
    </form>
</body>
</html>

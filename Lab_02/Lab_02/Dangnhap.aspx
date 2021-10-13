<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangnhap.aspx.cs" Inherits="Lab_02.Dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDangNhap" runat="server" Text="ĐĂNG NHẬP"></asp:Label>
            <br />
            <asp:Label ID="lblID" runat="server" Text="Tên đăng nhập"></asp:Label>
&nbsp;:<asp:TextBox ID="txtID" runat="server"></asp:TextBox>
&nbsp;<br />
            <asp:Label ID="lblPassword" runat="server" Text="Mật khẩu"></asp:Label>
&nbsp;:<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDangNhap" runat="server" OnClick="btnDangNhap_Click" Text="Đăng nhập"  />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblShow" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>

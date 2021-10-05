<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_01.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="TÍNH TOÁN"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Số n:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtSon" runat="server" Width="49px"></asp:TextBox>
        <br />
        Số m:
        <asp:TextBox ID="txtSom" runat="server" Width="50px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCong" runat="server" OnClick="btnCong_Click" Text="+" />
        <asp:Button ID="btnTru" runat="server" OnClick="btnTru_Click" Text="-" />
        <asp:Button ID="btnNhan" runat="server" OnClick="btnNhan_Click" Text="*" Width="26px" />
        <asp:Button ID="btnChia" runat="server" OnClick="btnChia_Click" Text="/" />
        <asp:Button ID="btnXoa" runat="server" OnClick="btnXoa_Click" Text="Xóa" />
        <br />
        Kết quả: <asp:TextBox ID="txtKetqua" runat="server" Width="61px"></asp:TextBox>
    </form>
</body>
</html>

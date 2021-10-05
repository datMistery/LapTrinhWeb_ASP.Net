<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thuchienpheptinh.aspx.cs" Inherits="Lab_01.Pages.Thuchienpheptinh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            THỰC HIỆN PHÉP TÍNH<br />
            A:&nbsp;
            <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
            <br />
            B:&nbsp;
            <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnCong" runat="server" OnClick="btnCong_Click" Text="A + B" />
&nbsp;<asp:Button ID="btnTru" runat="server" OnClick="btnTru_Click" Text="A - B" />
&nbsp;<asp:Button ID="btnNhan" runat="server" OnClick="btnNhan_Click" Text="A * B" />
&nbsp;<asp:Button ID="btnChia" runat="server" OnClick="btnChia_Click" Text="A / B" />
&nbsp;<asp:Button ID="btnChiaDu" runat="server" OnClick="btnChiaDu_Click" Text="A % B" />
            <br />
            <asp:TextBox ID="txtKetqua" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>

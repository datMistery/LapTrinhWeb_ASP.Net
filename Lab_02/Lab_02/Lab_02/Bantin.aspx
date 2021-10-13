<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bantin.aspx.cs" Inherits="Lab_02.Bantin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Bản tin cuối ngày<br />
            <asp:ImageButton ID="ImageButton2" runat="server" Height="16px" ImageUrl="~/star.png" Width="22px" />
&nbsp;Microsoft vừa công bố bản vá lỗi cho Windows 7
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True" ForeColor="#CC00FF" NavigateUrl="~/ChitietBantin.aspx?MaBT=Tin01">Xem chi tiết</asp:HyperLink>
        </div>
    </form>
</body>
</html>

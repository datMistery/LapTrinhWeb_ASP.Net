<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Lab_01.Pages.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Chào mừng bạn đến với ASP.Net<br />
            <asp:Label ID="lbNgay" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbThoigian" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

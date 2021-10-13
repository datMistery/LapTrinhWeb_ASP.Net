<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChaoMung.aspx.cs" Inherits="Lab_02.ChaoMung" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblChaoMung" runat="server" ForeColor="#66FFCC"></asp:Label>
            <br />
            <br />
            <asp:LinkButton ID="lbtnBack" runat="server" OnClick="lbtnBack_Click">Quay trở về trang đăng nhập</asp:LinkButton>
        </div>
    </form>
</body>
</html>

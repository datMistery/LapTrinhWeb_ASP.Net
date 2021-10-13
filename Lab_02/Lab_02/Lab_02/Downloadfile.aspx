<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Downloadfile.aspx.cs" Inherits="Lab_02.Download" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="16px" ImageUrl="~/star.png" Width="22px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Bài tập thực hành Lab02"></asp:Label>
&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True" ForeColor="#CC00FF" NavigateUrl="~/Lab02 - Cac doi tuong.Net.pdf">Click để Download</asp:HyperLink>
            <br />
&nbsp;<asp:ImageButton ID="ImageButton3" runat="server" Height="16px" ImageUrl="~/star.png" Width="22px" />
&nbsp;&nbsp;&nbsp;&nbsp; Bài tập thực hành Lab02
            <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" ImageUrl="~/download.jpg" OnClick="ImageButton1_Click" Width="30px" />
&nbsp;Tải về<br />
        </div>
    </form>
</body>
</html>

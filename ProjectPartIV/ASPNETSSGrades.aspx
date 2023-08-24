<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbGrade" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Add Grade" />
        </div>
        <asp:Label ID="lblAverage" runat="server"></asp:Label>
    </form>
</body>
</html>

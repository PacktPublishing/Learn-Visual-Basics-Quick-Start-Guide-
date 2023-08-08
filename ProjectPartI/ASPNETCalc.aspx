<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ASPNETCalc.aspx.vb" Inherits="ASPNETCalc.ASPNETCalc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <asp:TextBox id="n1" runat="server"/>
        <asp:TextBox id="n2" runat="server"/>
        <asp:DropDownList id="oper" runat="server">
            <asp:ListItem Text="+" Value="+" />
            <asp:ListItem Text="-" Value="-" />
            <asp:ListItem Text="*" Value="*" />
            <asp:ListItem Text="/" Value="/" />

        </asp:DropDownList>
        <asp:Button text="Submit" runat="server"/>
    </form>
</body>
</html>

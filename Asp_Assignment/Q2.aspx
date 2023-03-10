<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q2.aspx.cs" Inherits="Assignment.Q2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="208px" AutoPostBack="True">
            <asp:ListItem  Value="Fried Rice">Fried Rice</asp:ListItem>
            <asp:ListItem Value="Chicken Dry">Chicken Dry</asp:ListItem>
            <asp:ListItem Value="Momo">Momo</asp:ListItem>
           
        </asp:ListBox>
        <p>
            <asp:Image ID="img" runat="server" Height="113px" Width="195px" />
        </p>
        <asp:Button ID="show" runat="server" Height="29px" Text="Show" Width="65px" OnClick="Calculate" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="price" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

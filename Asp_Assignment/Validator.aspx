<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Assignment.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Insert Your Details </p>
        </div>
        <p>
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="name" runat="server"  autocomplete="off" OnTextChanged="TextBox1_TextChanged" Width="251px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="name" Display="Dynamic" ErrorMessage="Name is must" ForeColor="Red">*</asp:RequiredFieldValidator>
        </p>
        <p>
            Family Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="fname" runat="server" Width="245px" autocomplete="off"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="fname" Display="Dynamic" ErrorMessage="Family Name Is must" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="name" ControlToValidate="fname" ErrorMessage="Differ From Name" ForeColor="Black" Operator="NotEqual" Display="Dynamic"></asp:CompareValidator>
        </p>
        <p>
            Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="address" runat="server" Width="245px" autocomplete="off"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="address" ErrorMessage="Address is Mandatarory" ForeColor="Red">*</asp:RequiredFieldValidator>
<asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "address" ID="RegularExpressionValidator6" ValidationExpression = "^[\s\S]{2,5}$" runat="server" ErrorMessage="At Least 2 Chars"></asp:RegularExpressionValidator>

        </p>
        <p>
            City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="city" runat="server" Width="242px" autocomplete="off"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="city" Display="Dynamic" ErrorMessage="City is must" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "city" ID="RegularExpressionValidator5" ValidationExpression = "^[\s\S]{2,5}$" runat="server" ErrorMessage="At Least 2 Chars"></asp:RegularExpressionValidator>

        </p>
       
        <p>
            Zipcode :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="zp" runat="server" Width="238px" TextMode="Number" autocomplete="off"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"  ControlToValidate="zp" ErrorMessage="Zipcode is must" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="zp" Display="Dynamic" ErrorMessage="invalid format" ForeColor="Black" ValidationExpression="\d{5}">(xxxxx)</asp:RegularExpressionValidator>
        </p>
        <p>
            Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="phn" runat="server" Width="235px" TextMode="Number" autocomplete="off"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="phn" Display="Dynamic" ErrorMessage="This Field is required" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="phn" Display="Dynamic" ErrorMessage="invalid phone number" ForeColor="Black" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">(xx-xxxxxxx/ xxx-xxxxxxx)</asp:RegularExpressionValidator>
        </p>
        <p>
            E-Mail:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="email" runat="server" Width="238px" autocomplete="off"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="email" Display="Dynamic" ErrorMessage="Email is Must" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="email" ErrorMessage="invalid format" ForeColor="Blue" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">example@example.com</asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Button ID="btnCheck" runat="server" Text="Check" Width="98px" />
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="ValidationSum" ShowMessageBox="True" />
        <p>
            &nbsp; &nbsp;</p>
    </form>
</body>
</html>

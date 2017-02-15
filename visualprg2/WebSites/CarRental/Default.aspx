<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Car Rental Form</h1>
        <br />
        This page helps us to rent cars at the cheapest price.
        <br />
        <br />
        <br />
        Enter first name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Enter last name:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="This field cannot be blank" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        Enter the daily rental rate:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        Select the type of car:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True" Value="-1">(none)</asp:ListItem>
            <asp:ListItem>Subcompact</asp:ListItem>
            <asp:ListItem>Compact</asp:ListItem>
            <asp:ListItem>Mid-size</asp:ListItem>
        </asp:DropDownList>&nbsp;&nbsp; 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="You have to select the type of car" InitialValue="-1" ControlToValidate="DropDownList1" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        Enter the number of drivers:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Range is 1 - 2" MaximumValue="2" MinimumValue="1" ForeColor="Red"></asp:RangeValidator>
        <br />
        Enter the rental start date (mm/dd/yyyy):
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        &nbsp;Enter the returning date (mm/dd/yyyy):
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        &nbsp;
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox7" ControlToValidate="TextBox6" ErrorMessage="CompareValidator" Operator="LessThanEqual" ForeColor="Red" Type="Date">Return date has to be after the start date</asp:CompareValidator>
        <br />
        <br />
        <br />
        <br />
        Enter your email name:
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox8" ErrorMessage="Invalid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Send" />
    </form>
</body>
</html>

<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="myStyleSheet.css" />
    <style>
        body{color:darkslategrey
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Events</h1>
        Enter your name:
        <asp:TextBox ID="txtName" Columns="25" runat ="server"></asp:TextBox>
        <asp:Button ID ="btnOk" runat="server" Text="OK" />
        <p>
            <asp:ListBox ID="lstEvents" runat="server" Width="250px" Height="109px"></asp:ListBox>
        </p>

        <p>
            Hi there, I'm another paragraph on the page
        </p>
        <p>
            <asp:Label ID=lblBlue Text="My Name is... Slim." runat="server" CssClass="blueLabel"></asp:Label>
        </p>

        <p>
            <a href="Page2.aspx">Go to Page 2</a>
        </p>
<%--        <p>
            <a href="Page3.aspx">Go to Page 3</a>
        </p>--%>
        <p>
            <a href="Page4.aspx">Go to Page 4</a>
        </p>
        <p>
            <a href="Page5.aspx">Go to Page 5</a>
        </p>
    </form>
</body>
</html>

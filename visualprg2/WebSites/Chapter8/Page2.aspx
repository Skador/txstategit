<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Page2.aspx.vb" Inherits="Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="myStyleSheet.css" />
    <style>
        body {background-color:lightgreen;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        Are you a new student or a returning student?
        <asp:RadioButtonList ID="listStudent" runat="server" AutoPostBack="true">
            <asp:ListItem> New Student</asp:ListItem>
            <asp:ListItem> Returning Student</asp:ListItem>
        </asp:RadioButtonList>
        
        <asp:Panel ID="pnlNewStudent" runat="server" Visible="false">
            Create new account </p>
            Select a Username: <asp:TextBox ID="txtUserName" MaxLength="25" runat="server"></asp:TextBox></p>
            Select a Password: <asp:TextBox ID="txtPassword" MaxLength="25" runat="server"></asp:TextBox></p>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
        </asp:Panel>

        <asp:Panel ID="pnlReturningStudent" runat="server" Visible="false">
            Enter the returning account information </p>
            Enter Username: <asp:TextBox ID="txtUserNameL" MaxLength="25" runat="server"></asp:TextBox></p>
            Enter Password: <asp:TextBox ID="txtPasswordL" MaxLength="25" runat="server"></asp:TextBox></p>
            <asp:Button ID="btnSubmitL" runat="server" Text="Submit" />
        </asp:Panel>

        <a href="Default.aspx">Go back to Default</a>
    </form>
</body>
</html>

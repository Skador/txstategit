<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Click Application </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<%--        <h1>My Click Application</h1>
        <p style="text-align:center">
            <asp:Button ID="btnClick" runat="server" Text="Click Here" />
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </p>--%>

        <h1>Computer Department Student Picnic</h1>
        <p>
            First Name: 
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>        
        <p>
            Last Name: 
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="I am a Vegetarian" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Confirm" />
        </p>
        <p> 
            <asp:Label ID="Label2" runat="server" Text="" />
        </p>
        <asp:Panel ID="Panel1" runat="server">
            Author Name:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </asp:Panel>
        <p>
        </p>
    </div>
    </form>
</body>
</html>

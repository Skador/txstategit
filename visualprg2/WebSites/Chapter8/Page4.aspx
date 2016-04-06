<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Page4.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="myStyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox runat="server" ID="NameField"></asp:TextBox>
        <asp:button runat="server" ID="SubmitForm" OnClick="SubmitForm_Click" Text="Submit & Set Name" />
        <asp:button runat="server" ID="RefreshPage" Text="Just Submit" />
        <br /><br />
        Name retrieved from ViewState: <asp:Label runat="server" ID="NameLabel" CssClass="blueLabel" />
        <br />
        <br />
        <p>
            <a href="Page5.aspx"> Take me to page 5 and show me the session variable </a>
        </p>
        <a href="Default.aspx">Go back to Default</a>
    </form>
</body>
</html>

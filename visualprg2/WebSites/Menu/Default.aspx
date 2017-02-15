<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <h1> Menu Demo</h1>
        <table class="menu">
            <tr class="menuHead">
                <td>Select Kayak Type</td>
            </tr>
            <tr class="menuItem">
                <td ><a href="page1.aspx">Touring</a></td>
            </tr>
            <tr class="menuItem">
                <td><a href="">Surfing</a></td>
            </tr>
            <tr class="menuItem">
                <td><a href="">Racing</a></td>
            </tr>
            <tr class="menuItem">
                <td><a href="">Tandem</a></td>
            </tr>
            <tr class="menuItem">
                <td><a href="">Recreational</a></td>
            </tr>
        </table>

        <p>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>

        <p>
            <asp:Button ID="Button1" runat="server" Text="Upload" />
        </p>
  
    </form>
</body>
</html>
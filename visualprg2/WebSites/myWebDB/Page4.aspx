<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Page4.aspx.vb" Inherits="Page4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">

        function addNumbers(v1, v2) {

            var result;
            alert(result);
            result = parseInt(v1) + parseInt(v2);
            alert(result);
            return result;

        }

    </script>


</head>
<body>
    <form id="form1" runat="server">

        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Print" OnClientClick="window.print()" />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="VBButton" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="JSButton" OnClientClick="alert(addNumbers(form1.Textbox1.value, form1.Textbox2.value))" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Welcome" OnClientClick="alert('Welcome to my Page'); window.open('Page3.aspx')"/>
        <br />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="Page3" />

    </form>
</body>
</html>

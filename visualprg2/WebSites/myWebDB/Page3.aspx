<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Page3.aspx.vb" Inherits="Page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Button" />

        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="StudentID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="StudentID" HeaderText="StudentID" ReadOnly="True" SortExpression="StudentID" />
                <asp:BoundField DataField="StudentFName" HeaderText="StudentFName" SortExpression="StudentFName" />
                <asp:BoundField DataField="StudentLName" HeaderText="StudentLName" SortExpression="StudentLName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Student] WHERE ([StudentLName] LIKE '%' + @StudentLName + '%')" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Student] WHERE [StudentID] = @original_StudentID AND [StudentFName] = @original_StudentFName AND [StudentLName] = @original_StudentLName" InsertCommand="INSERT INTO [Student] ([StudentID], [StudentFName], [StudentLName]) VALUES (@StudentID, @StudentFName, @StudentLName)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Student] SET [StudentFName] = @StudentFName, [StudentLName] = @StudentLName WHERE [StudentID] = @original_StudentID AND [StudentFName] = @original_StudentFName AND [StudentLName] = @original_StudentLName">
            <DeleteParameters>
                <asp:Parameter Name="original_StudentID" Type="Int32" />
                <asp:Parameter Name="original_StudentFName" Type="String" />
                <asp:Parameter Name="original_StudentLName" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="StudentID" Type="Int32" />
                <asp:Parameter Name="StudentFName" Type="String" />
                <asp:Parameter Name="StudentLName" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="StudentLName" PropertyName="Text" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="StudentFName" Type="String" />
                <asp:Parameter Name="StudentLName" Type="String" />
                <asp:Parameter Name="original_StudentID" Type="Int32" />
                <asp:Parameter Name="original_StudentFName" Type="String" />
                <asp:Parameter Name="original_StudentLName" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <br />
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="StudentID" DataSourceID="SqlDataSource1" Height="50px" Width="203px">
            <Fields>
                <asp:BoundField DataField="StudentID" HeaderText="StudentID" ReadOnly="True" SortExpression="StudentID" />
                <asp:BoundField DataField="StudentFName" HeaderText="StudentFName" SortExpression="StudentFName" />
                <asp:BoundField DataField="StudentLName" HeaderText="StudentLName" SortExpression="StudentLName" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="StudentFName" DataValueField="StudentFName">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>

    </form>
</body>
</html>

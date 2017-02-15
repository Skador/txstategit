
Partial Class Page1
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Label1.Text = DropDownList1.SelectedItem.ToString
    End Sub
End Class

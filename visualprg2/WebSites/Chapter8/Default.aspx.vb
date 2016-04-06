
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lstEvents.Items.Add("Page_Load")
    End Sub

    Protected Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        lstEvents.Items.Add("Button_Click")
    End Sub

    Protected Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lstEvents.Items.Add("TextChanged")
    End Sub
End Class


Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub SubmitForm_Click(sender As Object, e As EventArgs) Handles SubmitForm.Click
        ViewState.Item("NameOfUser") = NameField.Text
        NameLabel.Text = NameField.Text
        Me.Session.Item("NameOfUser") = NameField.Text
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (ViewState("NameOfUser") IsNot Nothing) Then
            NameLabel.Text = ViewState("NameOfUser").ToString
        Else
            NameLabel.Text = "Not set yet..."
        End If
    End Sub

    Protected Sub RefreshPage_Click(sender As Object, e As EventArgs) Handles RefreshPage.Click
        If (ViewState("NameOfUser") IsNot Nothing) Then
            NameLabel.Text = ViewState("NameOfUser").ToString
        Else
            NameLabel.Text = "Not set yet..."
        End If
    End Sub
End Class


Partial Class Page2
    Inherits System.Web.UI.Page

    Enum typeStudent
        NewStudent
        ReturningStudent
    End Enum

    Protected Sub listStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listStudent.SelectedIndexChanged
        Select Case listStudent.SelectedIndex
            Case typeStudent.NewStudent
                pnlNewStudent.Visible = True
                pnlReturningStudent.Visible = False
            Case typeStudent.ReturningStudent
                pnlNewStudent.Visible = False
                pnlReturningStudent.Visible = True
        End Select
    End Sub
End Class

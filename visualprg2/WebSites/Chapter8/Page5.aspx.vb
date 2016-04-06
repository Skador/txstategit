
Partial Class Page5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Username.Text = Session("NameOfUser").ToString
    End Sub
End Class


Partial Class Page4
    Inherits System.Web.UI.Page

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim total = CInt(TextBox1.Text) + CInt(TextBox2.Text)
        MsgBox(total)
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Response.Redirect("Page3.aspx")
    End Sub
End Class

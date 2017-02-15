
Partial Class Page3
    Inherits System.Web.UI.Page

    Dim aCookie As HttpCookie

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        aCookie = New HttpCookie("textbox value is, ", TextBox1.Text)
        aCookie.Expires = Now.AddDays(3)
        Response.Cookies.Add(aCookie)
    End Sub
End Class


Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub btnPage1_Click(sender As Object, e As EventArgs) Handles btnPage1.Click
        Response.Redirect("Page1.aspx")
    End Sub

    Protected Sub btnPage2_Click(sender As Object, e As EventArgs) Handles btnPage2.Click
        Response.Redirect("Page2.aspx")
    End Sub
End Class


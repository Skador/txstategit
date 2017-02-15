
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uploadPath As String
        uploadPath = My.Request.PhysicalApplicationPath & "Pics\"
        FileUpload1.PostedFile.SaveAs(uploadPath & System.IO.Path.GetFileName(FileUpload1.FileName))
        MsgBox("The file, " & FileUpload1.FileName & " has been uploaded.")
    End Sub
End Class

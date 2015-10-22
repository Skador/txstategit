Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strfirst As String
        Dim STRuserinput As String = inputbox("Provide your first name.", "Enter your info.")
        strfirst = STRuserinput
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class

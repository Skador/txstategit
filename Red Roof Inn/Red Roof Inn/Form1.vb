Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Now.ToString("D")
        Label5.Text = Now.ToString("T")
    End Sub
End Class

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Hello World")
        ToolStripStatusLabel1.Text = "Hello World we are the Minions :)"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = ""
    End Sub


End Class
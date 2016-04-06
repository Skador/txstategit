Public Class Form1

    Dim bt1 As New Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Needs a flow layout panel
        bt1.Text = "Click me"

        AddHandler bt1.Click, AddressOf bt1_Click


        FlowLayoutPanel1.Controls.Add(bt1)
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs)
        MsgBox("Blah blah blah")
    End Sub

End Class

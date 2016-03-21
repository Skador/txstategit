Public Class Form1
    Dim letter As Char = "A"
    Dim temp As String = "A1c"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ch As Char = temp.Chars(0)
        If Char.IsDigit(ch) Then
            MsgBox("the char is a digit")
        Else
            MsgBox(ch)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox1.Leave
        'Button1.Enabled = TextBox1.Text.Length > 4
        If TextBox1.Text.Length = 0 Then
            ErrorProvider1.SetError(CType(sender, Control), "The Textbox cannot be blank")
            'TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = True
            ToolStripStatusLabel1.Text = "You cannot insert a special charater"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim n As Integer = CInt(TextBox3.Text)

        Catch ex As InvalidCastException
            MessageBox.Show(ex.StackTrace, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class

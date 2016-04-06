
Partial Class _Default
    Inherits System.Web.UI.Page

    'Protected Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
    '    lblMessage.Text = "That was a great click!"
    '    'MsgBox("Amazing click!!!")
    'End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Thank you for signing up for the picnic, " & TextBox1.Text & " " & TextBox2.Text & "."
        If CheckBox1.Checked Then
            Label2.Text &= " You will receive a vegetarian meal."
        Else
            Label2.Text &= " You will be dining on meat during the trip."
        End If
        Panel1.Visible = True
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox2.Focus()
        Panel1.Visible = False
    End Sub


End Class

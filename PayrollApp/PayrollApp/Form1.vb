Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare Variables and Constants
        Dim hrsWorked As Decimal           ' Total Hours Worked
        Dim othrsWorked As Decimal         ' Overtime Hours Worked
        'Dim otPay As Decimal               ' Overtime Wages
        Dim subTotal As Decimal            ' Subtotal of Wages
        Dim totalWages As Decimal          ' Total of Wages
        Const payRate As Decimal = 20D ' Hourly Pay Rate

        Try
            ' Calculate the amount of pay
            hrsWorked = CDec(TextBox1.Text)
            
            ' Check for overtime
            If hrsWorked > 40 Then
                othrsWorked = hrsWorked - 40
                subTotal = (hrsWorked - othrsWorked) * payRate
                totalWages = subTotal + (othrsWorked * (payRate * 1.5))
            Else
                totalWages = hrsWorked * payRate
            End If

            TextBox2.Text = totalWages.ToString("C")
        Catch
            MessageBox.Show("All input must be numberic - Try again.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
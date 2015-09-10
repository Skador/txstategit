Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalcGrade_Click(sender As Object, e As EventArgs) Handles btnCalcGrade.Click
        Dim numberGrade As Decimal
        Try
            numberGrade = CDec(txtGradeEntry.Text)
            If numberGrade >= 90 Then
                lblGradeFinal.Text = "A"
            ElseIf numberGrade < 90 And numberGrade >= 80 Then
                lblGradeFinal.Text = "B"
            ElseIf numberGrade < 80 And numberGrade >= 70 Then
                lblGradeFinal.Text = "C"
            ElseIf numberGrade < 70 And numberGrade >= 60 Then
                lblGradeFinal.Text = "D"
            Else
                lblGradeFinal.Text = "F"
            End If
        Catch ex As Exception
            MessageBox.Show("All inputs must be valid numerical values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGradeEntry.Clear()
        lblGradeFinal.Text = String.Empty
    End Sub
End Class

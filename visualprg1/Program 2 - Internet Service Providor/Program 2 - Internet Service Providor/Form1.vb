Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim total As Decimal
        Dim subTotal As Decimal
        Dim hours As Decimal
        Const hrsInMonth As Decimal = 744
        Const rateA As Decimal = 9.95
        Const limitA As Decimal = 10
        Const extraHrsAcost As Decimal = 2
        Const rateB As Decimal = 14.95
        Const limitB As Decimal = 20
        Const extraHrsBcost As Decimal = 1
        Const rateC As Decimal = 19.95
        Const discount As Decimal = 0.2
        Try
            If CDec(txtNbrHrsEntered.Text) > hrsInMonth Then
                Error 1
            End If
            Try
                If rbPackageA.Checked = True Then
                    If CDec(txtNbrHrsEntered.Text) > limitA Then
                        hours = CDec(txtNbrHrsEntered.Text) - limitA
                        subTotal = rateA + (hours * extraHrsAcost)
                    Else
                        subTotal = rateA
                    End If
                ElseIf rbPackageB.Checked = True Then
                    If CDec(txtNbrHrsEntered.Text) > limitB Then
                        hours = CDec(txtNbrHrsEntered.Text) - limitB
                        subTotal = rateB + (hours * extraHrsBcost)
                    Else
                        subTotal = rateB
                    End If
                Else
                    subTotal = rateC
                End If
                If cbNonProfOrg.Checked = True Then
                    total = subTotal - (subTotal * discount)
                Else
                    total = subTotal
                End If
                lblTotalAmount.Text = total.ToString("C")
            Catch ex As Exception
                MessageBox.Show("The value must be numeric")
            End Try
        Catch ex As Exception
            MessageBox.Show("Hours can not exceed 744 hours")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the text field
        txtNbrHrsEntered.Clear()

        'Clears the label
        lblTotalAmount.Text = String.Empty

        'Resets the Radio buttons
        rbPackageA.Checked = False
        rbPackageB.Checked = False
        rbPackageC.Checked = False

        'Resets the Check box
        cbNonProfOrg.Checked = False
    End Sub
End Class
